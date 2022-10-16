using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public int currentSphereIndex;
    public GameObject[] sphereSkins;
    void Start()
    {
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
}
