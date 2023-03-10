using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnertwo : MonoBehaviour
{    
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _enemytwo;

private void Start()
{
    StartCoroutine(SpawnEnemytwo());
}

private IEnumerator SpawnEnemytwo()
{
    yield return new WaitForSeconds(10);
    Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
    Instantiate(_enemytwo, spawnPos, Quaternion.identity);
    StartCoroutine(SpawnEnemytwo());
}

}
