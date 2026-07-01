using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D body;
    [SerializeField] private GameObject _Food;
    [SerializeField] private Transform _FoodEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    int wall = -1;
    void Update()
    {
            body.linearVelocityX = wall;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.CompareTag("Wall"))
        {
            wall = wall * -1;
            

        }
        if (collision.gameObject.CompareTag("Player") && collision.transform.position.y > transform.position.y)
        {
        Instantiate(_Food, _FoodEnemy.position, _FoodEnemy.rotation);
                Destroy(gameObject);
        }
    }
}



