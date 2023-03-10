using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTwo1 : MonoBehaviour
{
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _enemyTwo;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnEnemyTwo());

    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(23f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemyTwo()
    {
        yield return new WaitForSeconds(10f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_enemyTwo, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemyTwo());
    }
}
