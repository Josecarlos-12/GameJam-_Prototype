using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool canPause;
    public GameObject pause;
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
}
