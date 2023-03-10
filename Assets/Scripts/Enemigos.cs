using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [SerializeField] private float _speed = 0f;

    private void FixedUpdate()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
