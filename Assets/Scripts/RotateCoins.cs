using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    [SerializeField] float speed = 100f;
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
