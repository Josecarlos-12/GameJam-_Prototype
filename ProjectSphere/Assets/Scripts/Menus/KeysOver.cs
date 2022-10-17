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
    public Transform level, blueP,redP,greenP; 
    public ChangeCharacter b,r,g;
    public MeshRenderer cBlue,pBlue, cRed,pRed, cGreen,pGreen;
    public Scenary scenary;
    public MoreSpeed speed;
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
        level.position = new Vector3(0, -0.25f, 30.3f);
        blueP.position= new Vector3(0, 8.8f, -69.21f);
        redP.position = new Vector3(0, 8.8f, -69.21f);
        greenP.position = new Vector3(0, 8.8f, -69.21f);
        cBlue.material.color = blue.color;
        pBlue.material.color = blue.color;
        cRed.material.color = red.color;
        pRed.material.color = red.color;
        cGreen.material.color = green.color;
        pGreen.material.color = green.color;
        //SceneManager.LoadScene("Level");
        Time.timeScale = 1;
        over.SetActive(false);
        green.deathPlayer = false;
        red.deathPlayer = false;
        blue.deathPlayer = false;
        green.count = 0;
        red.count = 0;
        blue.count = 0;
        b.death = false;
        r.death = false;
        g.death = false;
        scenary.speed = -5;
        speed.time = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money"));
    }

    public void Shop()
    {
        SceneManager.LoadScene("ShopMenu");
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money"));
    }
}
