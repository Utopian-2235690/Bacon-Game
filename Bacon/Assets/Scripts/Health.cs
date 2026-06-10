using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Healthy = 3;
    public TextMeshProUGUI health;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Healthy = Healthy - 1;
            health.text = "Health:" + Healthy.ToString();
        }
    }
}

