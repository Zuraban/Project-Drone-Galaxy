using UnityEngine;
using TMPro;
using System.Collections; //  директива

public class CountdownTimer : MonoBehaviour
{
    public TMP_Text countdownText;  //обр отсчет
    public float countdownTime = 10.0f; // Время обратного отсчета в секундах
    private bool isCounting = false;

    private void Start()
    {
        StartCountdown();
    }

    private void Update()
    {
        if (isCounting)
        {
            countdownTime -= Time.deltaTime;

            // текущее значение отсчета 
            string minutes = Mathf.FloorToInt(countdownTime / 60).ToString("00");
            string seconds = Mathf.FloorToInt(countdownTime % 60).ToString("00");
            countdownText.text = minutes + ":" + seconds;

            
            if (countdownTime <= 0)
            {
                isCounting = false;
                // Доп действия по окончании отсчета
                Debug.Log("Countdown Finished!");
            }
        }
    }

    
    public void StartCountdown()
    {
        isCounting = true;
        StartCoroutine(Countdown());
    }

    // Корутина для обратного отсчета
    private IEnumerator Countdown()
    {
        while (countdownTime > 0)
        {
            yield return null;
        }

        // Завершение обратного отсчета
        isCounting = false;
        Debug.Log("Countdown Completed");
    }
}
