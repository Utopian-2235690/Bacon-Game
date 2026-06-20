using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public Rigidbody2D body;
    private bool canJump = false;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W) && canJump)
        {
            canJump = false;
            body.linearVelocityY = 7;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}

