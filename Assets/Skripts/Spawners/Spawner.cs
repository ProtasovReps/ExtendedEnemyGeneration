using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Alien _alienPrefab;
    [SerializeField] private Transform _spawnPoint;

    public void CreateAlien()
    {
        _alienPrefab.SetDirection(_spawnPoint.forward);
        _alienPrefab.transform.position = _spawnPoint.position;
        Instantiate(_alienPrefab);
    }
}