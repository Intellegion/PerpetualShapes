using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class bgcol : MonoBehaviour
{
    Color[] col = new Color[2];
    Camera cam;
    int i = 0;
    
    void Start()
    { 
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.white;
        col[0] = Color.white;
        col[1] = Color.black;
        StartCoroutine("Change");
    }
    IEnumerator Change()
    {
        while (true)
        {
            cam.backgroundColor = col[i];
            Debug.Log("index="+Array.IndexOf(col, cam.backgroundColor));
            i = (i == 0) ? 1 : 0;
            yield return new WaitForSeconds(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
