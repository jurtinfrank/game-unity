using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _bonus;
    [SerializeField] private GameObject _bonustwo;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());
        StartCoroutine(SpawnBonustwo());
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1.7f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnBonus()
    {
        yield return new WaitForSeconds(4.5f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_bonus, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnBonus());

    }

    private IEnumerator SpawnBonustwo()
    {
        yield return new WaitForSeconds(8.1f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_bonustwo, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnBonustwo());

    }

}
