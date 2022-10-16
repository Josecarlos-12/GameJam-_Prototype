using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelector : MonoBehaviour
{
    public int currentSphereIndex;
    public GameObject[] spheres;
    void Start()
    {
        currentSphereIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
        foreach (GameObject sphere in spheres)
        {
            sphere.SetActive(false);
        }

        spheres[currentSphereIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
