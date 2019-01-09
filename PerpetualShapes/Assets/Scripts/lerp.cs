using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
{
    float mul;
    void Start()
    {
        mul = Random.Range(3.0f, 5.0f);
    }
    void Update()
    {
        transform.position = new Vector3(-6.5f, Mathf.PingPong((Time.time*mul),6), 0.0f);
    }
}
