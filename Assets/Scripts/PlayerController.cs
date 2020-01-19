using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPosition;
    public float speed;
    public float incrementY;
    public float incrementX;
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;
    public int health;
    public GameObject playerParticleEffect;
    public Text healthDisplay;
    public GameObject gameOverUI;
    public GameObject playerSound;
    public GameObject scoreManager;       
    void Update()
    {
        healthDisplay.text = "Health : " + health.ToString();
        if(health <= 0)
        {
            gameOverUI.SetActive(true);
            scoreManager.SetActive(false);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            Instantiate(playerSound, transform.position, Quaternion.identity);
            Instantiate(playerParticleEffect, transform.position, Quaternion.identity);
            targetPosition = new Vector2(transform.position.x, transform.position.y + incrementY);
            transform.Rotate(new Vector3(0, 0, 1), 5);
            Debug.Log("Up Arrow Pressed");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            Instantiate(playerSound, transform.position, Quaternion.identity);
            Instantiate(playerParticleEffect, transform.position, Quaternion.identity);
            targetPosition = new Vector2(transform.position.x, transform.position.y - incrementY);
            transform.Rotate(new Vector3(0, 0, 1), -5);
            Debug.Log("Down Arrow Pressed");
        }      
        
    }
}
