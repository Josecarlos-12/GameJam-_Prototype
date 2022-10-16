using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation : MonoBehaviour
{
    public GameObject floors, floorsTwo;
    public float time;
    public float maxTime;
    public float distance;
    public Transform floorPosition;


    public GameObject[] objectDestroy;
    public Transform point;
    public float radius;
   

    void Update()
    {
        time+=Time.deltaTime;

        if(time> maxTime)
        {
            time=0;
            GameObject flor= Instantiate(floorsTwo, new Vector3(0, 0, floorPosition.position.z + distance), Quaternion.identity);
            floorPosition.position = flor.transform.position;
        }
    }

   
}
