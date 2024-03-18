using UnityEngine;

public class Alien : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    private float _speed = 5;

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.rotation = Quaternion.LookRotation(_direction, Vector3.up);
        transform.position += _direction * _speed * Time.deltaTime;
    }
}

