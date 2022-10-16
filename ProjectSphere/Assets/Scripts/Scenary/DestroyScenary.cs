using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScenary : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destrutible"))
        {
            //Destroy(other.gameObject.GetComponentInChildren<Transform>());
        }
    }
}
