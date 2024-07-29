using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Foward = 2f;
    public float Rorl = 2f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Foward * Time.deltaTime);

        if (Input.GetKey("a"))
            {
            rb.AddForce(-Rorl*Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Rorl * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
    if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    
    }
}
