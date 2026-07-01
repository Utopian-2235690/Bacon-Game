using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int randomNumber;

    public Rigidbody2D body;
    [SerializeField] private GameObject _Food1;
    [SerializeField] private GameObject _Food2;
    [SerializeField] private GameObject _Food3;
    [SerializeField] private GameObject _Food4;
    [SerializeField] private GameObject _Food5;
    [SerializeField] private GameObject _Food6;
    [SerializeField] private float _Speed = -1;

    [SerializeField] private Transform _FoodEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        body.linearVelocityX = _Speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.transform.position.y > transform.position.y) 
        {
            {
                Destroy(gameObject);
                randomNumber = Random.Range(1, 7);
                
                if(randomNumber == 1)
                {
                    Instantiate(_Food1, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                else if (randomNumber == 2)
                {
                    Instantiate(_Food2, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                else if (randomNumber == 3)
                {
                    Instantiate(_Food3, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                else if (randomNumber == 4)
                {
                    Instantiate(_Food4, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                else if (randomNumber == 5)
                {
                    Instantiate(_Food5, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                else if (randomNumber == 6)
                {
                    Instantiate(_Food6, _FoodEnemy.position, _FoodEnemy.rotation);
                }
                Destroy(gameObject);
            }
        }
    }
}
