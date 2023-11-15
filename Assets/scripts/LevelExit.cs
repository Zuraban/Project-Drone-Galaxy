using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // Добавляем директиву для IEnumerator

public class LevelExit : MonoBehaviour
{
    public float exitTime = 5.0f; // Время задержки перед выходом в меню
    private bool hasExited = false; // Флаг для отслеживания выхода

    public Timer timer; // Ссылка на скрипт таймера

    private void Update()
    {
        // Проверяем, отображен ли текст "Game Over"
        if (timer != null && !hasExited && !timer.IsRunning())
        {
            // Запускаем корутину для задержки перед выходом в меню
            StartCoroutine(ExitToMenuWithDelay());
        }
    }

    private IEnumerator ExitToMenuWithDelay()
    {
        // Ждем указанное количество секунд
        yield return new WaitForSeconds(exitTime);

        // После задержки загружаем меню
        SceneManager.LoadScene(0);  
        hasExited = true;
    }
}
