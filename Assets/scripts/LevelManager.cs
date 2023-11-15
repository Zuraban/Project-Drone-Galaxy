using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    // Вызывается при успешном завершении уровня
    public void LevelCompleted()
    {
        StartCoroutine(LoadMenuAfterDelay());
    }

    // Загрузка главного меню через 5 секунд
    private IEnumerator LoadMenuAfterDelay()
    {
        yield return new WaitForSeconds(5.0f); // Ждем 5 секунд

        // Загружаем главное меню
        SceneManager.LoadScene("Menu 2");
    }
}
