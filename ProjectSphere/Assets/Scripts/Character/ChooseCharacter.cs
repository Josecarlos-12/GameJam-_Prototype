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
            if(blue != null)
            blue.SetActive(true);

            if(red != null)
            red.SetActive(false);

            if(green != null)
            green.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Character") == 2)
        {
            if (red != null)
            red.SetActive(true);

            if (blue != null)
                blue.SetActive(false);
            if (green != null)
                green.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Character") == 3)
        {
            if (green != null)
                green.SetActive(true);

            if (blue != null)
                blue.SetActive(false);

            if (red != null)
                red.SetActive(false);

        }
    }
}
