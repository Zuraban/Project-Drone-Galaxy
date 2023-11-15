using UnityEngine;

public class DroneControlC : MonoBehaviour
{
    public Rigidbody Drone;

    public int ForwardBackward = 50;
    public int Tilt = 50;
    public int FlyLeftRight = 50;
    public int UpDown = 50;

    private Vector3 DroneRotation;
    public bool Mobile;
    private float Lx;
    private float Ly;

    void Update()
    {
        // Ваш код для получения значений Lx и Ly, например, из другого источника ввода
        // Lx = ...
        // Ly = ...
    }

    void FixedUpdate()
    {
        DroneRotation = Drone.transform.localEulerAngles;

        // Здесь остается код, связанный с управлением наклоном и поворотом дрона
        // ...

        if (Mobile == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Drone.AddRelativeTorque(0, -Tilt, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Drone.AddRelativeTorque(0, Tilt, 0);
            }

            // Добавляем управление вперед/назад и вверх/вниз с помощью клавиш клавиатуры
            if (Input.GetKey(KeyCode.W))
            {
                Drone.AddRelativeForce(0, 0, ForwardBackward);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Drone.AddRelativeForce(0, 0, -ForwardBackward);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Drone.AddRelativeForce(-FlyLeftRight, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Drone.AddRelativeForce(FlyLeftRight, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Drone.AddRelativeForce(0, UpDown, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Drone.AddRelativeForce(0, -UpDown, 0);
            }
        }

        if (Mobile == true)
        {
            // Здесь вы можете добавить свои собственные механизмы управления для мобильных устройств
            // Например, использовать акселерометр или тач-экран
        }

        // Оставляем эту часть кода для применения силы вверх, чтобы дрон не падал слишком быстро
        Drone.AddForce(0, 9, 0);
    }
}
