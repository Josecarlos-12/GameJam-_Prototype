using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Color color;

    public float life;
    public GameObject floor;
    public Scenary scenary;
    public int count;
    public MeshRenderer sphere, box;

    public GameObject jump, transformOn;
    public float reductionvelocity;
    public ChangeCharacter death;
    public bool deathPlayer;

    private void Update( )
    {
        if ( count>1)
        {
            death.death = true;
            deathPlayer = true;
            Time.timeScale = 0;
            //Destroy(gameObject);
            sphere.material.color= Color.gray;
            box.material.color= Color.gray;
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
            scenary.speed = scenary.speed + reductionvelocity;
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            deathPlayer = true;
            death.death = true;
            Time.timeScale = 0;
            sphere.material.color = Color.gray;
            box.material.color = Color.gray;
        }
        if (other.gameObject.name == "Saltar")
        {
            jump.SetActive(true);
        }
        if (other.gameObject.name == "Tranformar")
        {
            transformOn.SetActive(true);
        }
        if (other.gameObject.name == "Final")
        {
            SceneManager.LoadScene("FinalGame");
        }
    }
}
