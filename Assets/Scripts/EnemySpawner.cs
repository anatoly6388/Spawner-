
using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Spawnerpoint[] _spawnPoint;
    [SerializeField][Range(1, 10)] private int _delay;

    private bool _isWork= true;
    private WaitForSeconds _wait;


    private void Start()
    {
        _wait = new WaitForSeconds(_delay);
        StartCoroutine(Spawning());       
    }

    private IEnumerator Spawning()
    {
        while (_isWork)
        {
            int index = Random.Range(0, _spawnPoint.Length);
            _spawnPoint[index].Spawn();
            yield return _wait;
        }
    }
}
