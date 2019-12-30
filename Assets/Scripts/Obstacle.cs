using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;   
    public int damage = 1;
    public GameObject particleEffect;
    public GameObject explosionSound;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);                        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            Instantiate(particleEffect, transform.position, Quaternion.identity);
            collision.GetComponent<PlayerController>().health -= damage;
            //Debug.Log(collision.GetComponent<PlayerController>().health);
            Destroy(gameObject);
        }
    }
}
