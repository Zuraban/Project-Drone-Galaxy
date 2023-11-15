using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    public float rotationSpeed = 1000.0f;

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}