using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool canPause;
    public GameObject pause;

    public Transform level, playerB,playerR,playerG;
    public Scenary scenary;
    public MoreSpeed speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canPause = !canPause;

            if (canPause)
            {
                pause.SetActive(true);
                Time.timeScale = 0f;
            }

            else if (!canPause)
            {
                pause.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }

    public void Continue()
    {
        canPause = false;
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartPause()
    {
        level.position = new Vector3(0, -0.25f, 30.3f);
        //SceneManager.LoadScene("Level");
        Time.timeScale = 1;
        pause.SetActive(false);
        canPause = false;
        playerB.position = new Vector3(0, 8.8f, -69.21f);
        playerR.position = new Vector3(0, 8.8f, -69.21f);
        playerG.position = new Vector3(0, 8.8f, -69.21f);
        scenary.speed = -5;
        speed.time = 0;
    }
}
