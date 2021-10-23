 using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool alive = true;

    public float speed = 10;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    public float jumpForce = 400f;
    public LayerMask groundMask;


    void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMode = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMode + horizontalMove);
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");    
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Jump();
        }
        if(transform.position.y < -5)
        {
            Die();
        }
    }


    public void Die () 
    {
        alive = false;
        Invoke("Restart", 2);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Jump ()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height/2)+ 0.1f, groundMask);

        rb.AddForce(Vector3.up * jumpForce);
    }

}
