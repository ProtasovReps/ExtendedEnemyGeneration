using System.Collections;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _delay;

    void Start()
    {
        StartCoroutine(ActivateRandomSpawner());
    }

    private IEnumerator ActivateRandomSpawner()
    {
        var delay = new WaitForSeconds(_delay);
        bool isWorking = true;

        while (isWorking)
        {
            int randomIndex = Random.Range(0, _spawners.Length);
            _spawners[randomIndex].CreateAlien();
            yield return delay;
        }
    }
}