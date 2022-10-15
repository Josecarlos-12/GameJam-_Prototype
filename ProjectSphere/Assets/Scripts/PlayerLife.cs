using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public float life;

    private void Update( )
    {
        if ( life <= 0 )
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Obstacle") )
        {
            life--;
        }
    }
}
