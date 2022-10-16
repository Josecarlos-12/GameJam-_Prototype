using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int moneys;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Money"))
        {
            Debug.Log("Toco");
            Destroy(collision.gameObject);
        }
    }
}
