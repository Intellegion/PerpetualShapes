using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    int mul;
    void Start()
    {
        mul= (Random.Range(0.0f,1.0f)>0.5)?1 : -1;
    }
    void Update()
    {
        transform.Rotate(0,0,mul*Random.Range(1,5.0f));
    }
}
