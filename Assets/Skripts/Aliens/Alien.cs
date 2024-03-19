using UnityEngine;

public class Alien : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private float _speed = 3;

    private void Update()
    {
        ChaseTarget();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void ChaseTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        transform.LookAt(_target.position);
    }
}

