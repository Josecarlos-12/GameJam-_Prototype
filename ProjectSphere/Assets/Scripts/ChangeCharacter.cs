using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public GameObject sphere, cube;
    public bool change;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.T) )
        {
            change = !change;
            
            if ( change ) 
            {
                cube.SetActive(true);
                sphere.SetActive(false);
            }
            if (change == false) 
            {
                cube.SetActive(false);
                sphere.SetActive(true);
            }
        }
    }
}
