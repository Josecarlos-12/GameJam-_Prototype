using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreSpeed : MonoBehaviour
{
    public float time;
    public float maxSpeed;
    public Scenary scenary;
    public float moreSpeed;

    private void Update()
    {
        time += Time.deltaTime;
        if(time> maxSpeed)
        {
            time = 0;
            scenary.speed+= moreSpeed;
        }
    }

}
