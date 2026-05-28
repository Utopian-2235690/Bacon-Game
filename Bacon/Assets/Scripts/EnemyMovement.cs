using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocityX = -1;
    }
}

