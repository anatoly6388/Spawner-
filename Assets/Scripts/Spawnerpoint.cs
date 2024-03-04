
using UnityEngine;

public class Spawnerpoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private EnemyMover _prefab;

    public void Spawn()
    {
        EnemyMover enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        enemy.SetTarget(_target);
    }

}
