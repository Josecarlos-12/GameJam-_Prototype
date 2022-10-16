using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewaysForce = 12f;


    public Vector3 inputMove;

    public float jumpForce;
    public bool canJump;

    private void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.3f, 4.3f), transform.position.y, transform.position.z);

        inputMove.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(inputMove.x * sidewaysForce, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = false;
        }
    }

}
