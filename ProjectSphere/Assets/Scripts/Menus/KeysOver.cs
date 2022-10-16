using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeysOver : MonoBehaviour
{
    public PlayerLife blue,red,green;
    public GameObject over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blue.deathPlayer)
        {
            over.SetActive(true);
        }

        if (red.deathPlayer)
        {
            over.SetActive(true);
        }

        if (green.deathPlayer)
        {
            over.SetActive(true);

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;

    }

    public void Shop()
    {
        SceneManager.LoadScene("ShopMenu");
        Time.timeScale = 1;
    }
}
