using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeShop : MonoBehaviour
{
    public int currentSphereIndex;
    public GameObject[] sphereSkins;

    public GameObject blockRed;
    public GameObject blockGreen;

    public bool redd;

    public bool desblo1,desblo2;

    public TextMeshProUGUI tex;
    void Start()
    {
        //PlayerPrefs.SetInt("Money", 0);
        //PlayerPrefs.SetInt("Prota", 0);
        //PlayerPrefs.SetInt("ProtaT", 0);
        //PlayerPrefs.SetInt("Character", 1);


        currentSphereIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
        foreach (GameObject sphere in sphereSkins)
        {
            sphere.SetActive(false);
        }
        sphereSkins[currentSphereIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        tex.text = "Pheres: " + PlayerPrefs.GetInt("Money").ToString("0");
        Debug.Log(PlayerPrefs.GetInt("Money"));
        if(PlayerPrefs.GetInt("ProtaT") == 3)
        {
            blockGreen.SetActive(false);
        }

        if( PlayerPrefs.GetInt("Prota") == 2)
        {
            blockRed.SetActive(false);
        }
    }

    public void ChangeNext()
    {
        sphereSkins[currentSphereIndex].SetActive(false);

        currentSphereIndex++;
        if (currentSphereIndex == sphereSkins.Length)
        {
            currentSphereIndex = 0;
        }
        sphereSkins[currentSphereIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedSkin", currentSphereIndex);
    }

    public void ChangeBack()
    {
        sphereSkins[currentSphereIndex].SetActive(false);

        currentSphereIndex--;
        if (currentSphereIndex == -1)
        {
            currentSphereIndex = sphereSkins.Length - 1;
        }
        sphereSkins[currentSphereIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedSkin", currentSphereIndex);
    }

    public void Buy()
    {
        if (currentSphereIndex == 0)
        {
            
        }
        if (PlayerPrefs.GetInt("Money")>14 && currentSphereIndex==1)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money")-15);
            PlayerPrefs.SetInt("Prota", 2);
            desblo1 = true;
            Debug.Log("ComproRojo");
        }

        if (PlayerPrefs.GetInt("Money") > 19 && currentSphereIndex == 2)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money")-20);
            PlayerPrefs.SetInt("ProtaT", 3);
            desblo2 = true;
            Debug.Log("ComproVerde");
        }
        
    }

    public void Chose()
    {
        if(currentSphereIndex == 0)
        {
            PlayerPrefs.SetInt("Character", 1);
            Debug.Log("Elegi1");
        }
        if (currentSphereIndex == 1 && PlayerPrefs.GetInt("Prota") == 2)
        {
            PlayerPrefs.SetInt("Character", 2);
            Debug.Log("Elegi2");
        }
        if (currentSphereIndex == 2 && PlayerPrefs.GetInt("ProtaT") == 3)
        {
            Debug.Log("Elegi1}3");
            PlayerPrefs.SetInt("Character", 3);

        }
    }
}
