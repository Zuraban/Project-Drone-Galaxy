using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Ск движения дрона
    public float rotationSpeed = 6.0f; // Скорость вращения дрона
    public float maxTiltAngle = 30.0f; // Максимальный угол наклона


    private float currentTiltX = 1.0f; // Текущий угол наклона по X
    private float currentTiltZ = 1.0f; // Текущий угол наклона по Z
    

    void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal"); // ввод по горизонтали 
        float verticalInput = Input.GetAxis("Vertical"); //  ввод по вертикали 
        float upInput = Input.GetKey(KeyCode.Space) ? 0.5f : 0.0f; // Подъем дрона 
        float downInput = Input.GetKey(KeyCode.LeftShift) ? 1.0f : 0.0f; // Опускание дрона 
        float rotationInputR = Input.GetKey(KeyCode.Z) ? 0.5f : 0.0f; //  вращение 
        float rotationInputL = Input.GetKey(KeyCode.X) ? 0.5f : 0.0f;


        Vector3 translation = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        Vector3 upVector = Vector3.up * (upInput - downInput) * moveSpeed * Time.deltaTime;

        //Угол наклона по X в зависимости от движения вперед/назад
        float targetTiltX = verticalInput * maxTiltAngle;

        // У%гол наклона по Z в зависимости от движения влево/вправо
        float targetTiltZ = -horizontalInput * maxTiltAngle;

        float tiltSpeed = 2;
        // Плавно меняем угол наклона по X и Z
        currentTiltX = Mathf.Lerp(currentTiltX, targetTiltX, tiltSpeed * Time.deltaTime);
        currentTiltZ = Mathf.Lerp(currentTiltZ, targetTiltZ, tiltSpeed * Time.deltaTime);

        // Quaternion для наклона дрона
        Quaternion tiltQuaternion = Quaternion.Euler(currentTiltX, 0, currentTiltZ);

        // Применяем наклон к дрону
        transform.localRotation = Quaternion.Slerp(transform.localRotation, tiltQuaternion, Time.deltaTime * tiltSpeed);

        // Вращение дрона вокруг оси Y
        transform.Rotate(Vector3.down, rotationInputR * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationInputL * rotationSpeed * Time.deltaTime);

        transform.Translate(translation);
        transform.position += upVector;
    }

    private void FixedUpdate()
    {
        

        

    }
}
