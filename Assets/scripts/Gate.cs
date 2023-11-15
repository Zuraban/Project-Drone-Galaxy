using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections;

public class Gate : MonoBehaviour
{
    public ParticleSystem gateParticles; // Ссылка на компонент Particle System
    public UnityEvent onPassThrough; // Событие, которое срабатывает при пересечении ворот
    public string textToShow = "Gate Passed"; // Текст для отображения
    public Timer timer; // Ссылка на скрипт таймера
    public bool shouldLoadNextScene = true; // Переменная, которая определяет, должен ли произойти переход на следующую сцену
    public bool Timer = true;
    public float delayBeforeLoad = 2.0f; // Задержка перед переходом на следующий уровень
    private GateText gateText;

    [System.Obsolete]
    private void Start() => gateText = FindObjectOfType<GateText>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drone"))
        {
            // Вызываем событие прохождения ворот
            onPassThrough.Invoke();
            gateParticles.Stop();
            //Debug.Log("ворота!");

            // Отображаем текст при пересечении
            //gateText.ShowGateText(textToShow);

            if (Timer)
            {
                // Остановка таймера при прохождении ворот
                //timer.StopTimer();
            }

            // Запускаем корутину для задержки перед переходом на следующий уровень
            StartCoroutine(LoadNextSceneWithDelay());
        }
    }

    private IEnumerator LoadNextSceneWithDelay()
    {
        // Ждем указанное количество секунд
        yield return new WaitForSeconds(delayBeforeLoad);

        // После задержки выполняем переход на следующий уровень
        if (shouldLoadNextScene)
        {
            // Загружаем следующую сцену по индексу текущей + 1
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
