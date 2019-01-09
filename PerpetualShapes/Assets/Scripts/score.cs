using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private TextMeshProUGUI scoreT;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreT = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreT.text = ((int)(playercontrol.score)).ToString();
        
    }
}
