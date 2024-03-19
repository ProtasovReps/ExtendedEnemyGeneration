using System.Collections;
using UnityEngine;

public class AlienSpawnManager : MonoBehaviour
{
    [SerializeField] private AlienSpawner[] _spawners;
    [SerializeField] private float _delay;

    private void Start()
    {
        StartCoroutine(CreateAlienAtRandomSpawner());
    }

    private IEnumerator CreateAlienAtRandomSpawner()
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