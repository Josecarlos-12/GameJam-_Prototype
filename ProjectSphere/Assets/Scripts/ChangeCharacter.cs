using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public int moneys;
    public GameObject sphere, cube;
    public bool change;

    public bool death;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Money", moneys);

        if ( Input.GetKeyDown(KeyCode.T) )
        {
            if(!death)
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Money"))
        {
            if (!change)
            {
                moneys++;
                Debug.Log("Toco");
                Destroy(other.gameObject);
            }
            
        }
    }
}
