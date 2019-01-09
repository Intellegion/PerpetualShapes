using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseUI;
    public GameObject player;
    void Start()
    {

        Resume();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
         
    }
    public void Resume()
    {
        player.GetComponent<playercontrol>().enabled = true;
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        isPaused = false;
    }
    public void Pause()
    {
        player.GetComponent<playercontrol>().enabled = false;
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        isPaused = true;
    }
}
