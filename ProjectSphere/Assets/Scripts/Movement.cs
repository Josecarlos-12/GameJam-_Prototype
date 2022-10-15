using UnityEngine;

public class Movement : MonoBehaviour
{
    public float gravityF;
    public Rigidbody rb;

    public float speedZ = 15f;
    public float sidewaysForce = 12f;


    public Vector3 inputMove;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speedZ);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.3f, 4.3f), transform.position.y,transform.position.z);

        rb.velocity =  transform.forward + inputMove.x * sidewaysForce * transform.right;

        inputMove.x = Input.GetAxis("Horizontal");
        //Vector3 velocity = Vector3.zero;
        if ( inputMove.x > 1 || inputMove.z > 1 )
        {
            
            if ( this.gameObject.transform.position.x > LevelBoundary.leftSide )
            {
                rb.velocity =  transform.forward + transform.right * sidewaysForce * inputMove.x;
                /*velocity.y = rb.velocity.y;
                rb.velocity = velocity * gravityF;*/
            }

        }
        if ( inputMove.x < 1 || inputMove.z < 1 )
        {
            
            if ( this.gameObject.transform.position.x < LevelBoundary.rightSide ) 
            {
                rb.velocity =  transform.forward + inputMove.x * sidewaysForce* transform.right;
            }
                
        }
        //velocity.y += gravityF * Time.deltaTime;
        
    }
}
