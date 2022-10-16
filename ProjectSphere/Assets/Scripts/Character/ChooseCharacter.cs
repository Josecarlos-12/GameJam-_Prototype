using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    public GameObject blue, red, green;
    public ChangeCharacter change, change1, change2;
    public TextMeshProUGUI text;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Pheres: " + PlayerPrefs.GetInt("Money").ToString("0");
        PlayerPrefs.SetInt("Money", change.moneys+change1.moneys+change2.moneys);


        if (PlayerPrefs.GetInt("Character") == 1)
        {
            blue.SetActive(true);
            red.SetActive(false);
            green.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Character") == 2)
        {
            red.SetActive(true);
            blue.SetActive(false);
            green.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Character") == 3)
        {
            green.SetActive(true);
            blue.SetActive(false);
            red.SetActive(false);
        }
    }
}
