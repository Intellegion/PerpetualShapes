using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensi : MonoBehaviour
{
    public Slider slid;

    public void Change()
    {
        playercontrol.sensitivity = slid.value;     
    }
}
