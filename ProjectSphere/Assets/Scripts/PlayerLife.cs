using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public float life;
    public GameObject floor;
    public Scenary scenary;
    public int count;

    public GameObject jump,transform;

    private void Update( )
    {
        if ( count>1)
        {
            Destroy(gameObject);
        }
    }

     public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Small"))
        {
            Debug.Log("smaal"); 
            floor.transform.position = new Vector3(0, 0, floor.transform.position.z-20);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Small"))
        {
            count++;
            Debug.Log("smaal");
            floor.transform.position = new Vector3(0, 0, floor.transform.position.z + 4);
            scenary.speed = scenary.speed + 900;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.name == "Saltar")
        {
            jump.SetActive(true);
        }
        if (other.gameObject.name == "Tranformar")
        {
            transform.SetActive(true);
        }
    }
}
