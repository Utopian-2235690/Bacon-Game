using UnityEngine;

public class FriesMovement : MonoBehaviour
{
    int randomNumber;

    public Rigidbody2D body;
    [SerializeField] private float _Speed = -1.5f;

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocityX = _Speed;
    }
}