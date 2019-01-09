using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playercontrol : MonoBehaviour {
    SpriteRenderer playercol;
    private Rigidbody2D rb;
    public static float score;
    float move;
    public static float sensitivity = 0.3f;
    private Transform pt;
    public static float hscore = 0;
    // Use this for initialization
    void Start ()
    {
        Cursor.visible = false;
        score = 0;
        playercol = GetComponent<SpriteRenderer>();
        pt = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        playercol.color = Color.black;
    }	
	// Update is called once per frame
	void FixedUpdate()
    {      
        rb.velocity = new Vector2(0.0f, 15.0f);
    }
    void Update()
    {
        score += Time.deltaTime;
        move = Input.GetAxis("Horizontal") * Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            if (playercol.color == Color.white)
                playercol.color = Color.black;
            else
                playercol.color = Color.white;
        }
        transform.Translate(move * sensitivity, 0.0f, 0.0f, Space.World);
        if(Mathf.Abs(transform.position.x)>=12)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Cursor.visible = true;
        SceneManager.LoadScene(2);
    }
}
