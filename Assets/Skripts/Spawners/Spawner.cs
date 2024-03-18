using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Alien _alienPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _survivor;

    public void CreateAlien()
    {
        _alienPrefab.SetTarget(_survivor);
        _alienPrefab.transform.position = _spawnPoint.position;
        Instantiate(_alienPrefab);
    }
}