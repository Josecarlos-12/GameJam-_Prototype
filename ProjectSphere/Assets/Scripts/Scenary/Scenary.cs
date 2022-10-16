using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class Scenary : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
         rb.velocity = new Vector3(0, 0, speed);
        //rb.AddForce(transform.forward * speed);
    }
}
