using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject explosionParticleEffectbyFire;
    public GameObject explosionSound;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * speed;
    }
    private void Update()
    {
        if(transform.position.x >= 10)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            
            Instantiate(explosionParticleEffectbyFire, transform.position, Quaternion.identity);
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
}
