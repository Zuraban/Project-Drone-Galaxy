using UnityEngine;

public class MoveableSecond : MonoBehaviour
{
    [Header("Old system move")] [Space]
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        Vector2 directionMove = new Vector2(horAxis, verAxis);
        MovePlayer(directionMove);

        if (Input.GetMouseButtonDown(0))
            Attack();
    }

    private void MovePlayer(Vector2 directionMove)
    {
        Vector3 direction = new Vector3(directionMove.x, 0, directionMove.y);
        transform.position += direction * _moveSpeed * Time.deltaTime;
    }

    private void Attack()
    {
        Debug.Log("Attack!");
    }
}