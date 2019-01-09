using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilecol : MonoBehaviour
{
    SpriteRenderer col;
    Color[] colour = new Color[7];
    // Start is called before the first frame update
    void Start()
    {
        colour[0] = Color.blue;
        colour[1] = Color.yellow;
        colour[2] = Color.green;
        colour[3] = Color.cyan;
        colour[4] = Color.red;
        colour[5] = Color.grey;
        colour[6] = Color.magenta;
        col = GetComponent<SpriteRenderer>();
        col.color = colour[Mathf.RoundToInt(UnityEngine.Random.Range(0,6))];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
