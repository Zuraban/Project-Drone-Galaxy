using UnityEngine;

public class MoveableOne : MonoBehaviour
{
    [Header("Very cool system move (not)")] [Space]
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Vector3 directionMove = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            directionMove.z += 1f;

        if (Input.GetKey(KeyCode.S))
            directionMove.z -= 1f;

        if (Input.GetKey(KeyCode.A))
            directionMove.x -= 1f;

        if (Input.GetKey(KeyCode.D))
            directionMove.x += 1f;

        transform.position += directionMove * _moveSpeed * Time.deltaTime;
    }
}
