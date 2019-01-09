using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highscore : MonoBehaviour
{
    TextMeshProUGUI hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = GetComponent<TextMeshProUGUI>();
        if (playercontrol.score > playercontrol.hscore)
            playercontrol.hscore = playercontrol.score;
        hs.text = "Score = "+((int)playercontrol.score).ToString()+"\nHigh Score = "+((int)(playercontrol.hscore)).ToString();
        
    } 
}
