using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerContollerL : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector3 _direction;
    private bool isPaused = false;

    public float rotationSpeed = 6.0f; // Скорость вращения дрона
    public float maxTiltAngle = 30.0f; // Максимальный угол наклона
    private float currentTiltX = 0.0f; // Текущий угол наклона по X
    private float currentTiltZ = 0.0f; // Текущий угол наклона по Z

    private void Update()
    {
        if (!isPaused)
        {
            Move(_direction);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector3>();
    }

    private void Move(Vector3 directionMove)
    {
        Vector3 direction = new Vector3(directionMove.x, directionMove.z, directionMove.y);
        transform.position += direction * _moveSpeed * Time.deltaTime;

        // Угол наклона по X в зависимости от движения вперед/назад
        float targetTiltX = directionMove.y * maxTiltAngle;

        // Угол наклона по Z в зависимости от движения влево/вправо
        float targetTiltZ = -directionMove.x * maxTiltAngle;

        float tiltSpeed = 2;
        // Плавно меняем угол наклона по X и Z
        currentTiltX = Mathf.Lerp(currentTiltX, targetTiltX, tiltSpeed * Time.deltaTime);
        currentTiltZ = Mathf.Lerp(currentTiltZ, targetTiltZ, tiltSpeed * Time.deltaTime);

        // Quaternion для наклона дрона
        Quaternion tiltQuaternion = Quaternion.Euler(currentTiltX, 0, currentTiltZ);

        // Применяем наклон к дрону
        transform.localRotation = Quaternion.Slerp(transform.localRotation, tiltQuaternion, Time.deltaTime * tiltSpeed);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack!");
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            TogglePause();
        }
    }

    public void OnReturnToMenu(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            ReturnToMenu();
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        
        Time.timeScale = 0f; // Замораживаем время
    }

    private void ResumeGame()
    {
        
        Time.timeScale = 1f; // Возобновляем время
    }

    private void ReturnToMenu()
    {
        
        SceneManager.LoadScene(0);
        Time.timeScale = 1f; // Возобновляем время при возвращении в меню
    }
}

