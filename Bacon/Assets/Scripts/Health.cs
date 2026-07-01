using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Healthy = 3;
    public TextMeshProUGUI health;
    [SerializeField] private Transform SpawnLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Healthy == 0)
        {
            health.text = "Health: 3"; Healthy = 3; transform.position = SpawnLocation.position;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && collision.transform.position.x > transform.position.x || collision.gameObject.CompareTag("Enemy") && collision.transform.position.x < transform.position.x)
        {
            Healthy = Healthy - 1;
            health.text = "Health:" + Healthy.ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fries"))
        {
            Healthy = Healthy - 1;
            health.text = "Health:" + Healthy.ToString();
        }
    }
}

