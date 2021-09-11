using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool alive = true;

    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

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

}
