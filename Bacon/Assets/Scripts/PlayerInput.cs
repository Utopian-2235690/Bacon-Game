using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Rigidbody2D body;
    private bool canJump = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && canJump)
        {
            canJump = false;
            body.linearVelocityY = 7;
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.linearVelocityX = -5;
        }

        if (Input.GetKey(KeyCode.D))
        {
            body.linearVelocityX = 5;
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.linearVelocityY = -10;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
           
            if (body.linearVelocity.y < -0.1f)
            {
                Destroy(collision.gameObject);
                

                body.linearVelocity = new Vector2(body.linearVelocity.x, 5f);
            }
        }
    }
}
