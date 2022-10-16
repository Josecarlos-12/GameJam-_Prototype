using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public int currentSphereIndex =0;
    public GameObject [] sphereSkins;
    void Start()
    {
        foreach(GameObject sphere in sphereSkins)
        {
            sphere.SetActive(false);
        }
        sphereSkins[currentSphereIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
