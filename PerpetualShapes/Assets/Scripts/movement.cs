using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public GameObject player;
    Transform ct;
    float moveup = 10.0f;
	void Start () {
        moveup *= Time.deltaTime;
        ct =GetComponent<Transform>();
        }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        ct.position = new Vector3(0.0f,player.transform.position.y+5.0f,-15.0f);
    }
}
