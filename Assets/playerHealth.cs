using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpPower = 10f;
    public int maxHealth = 3;
    private int currentHealth;
    public GameObject gameOverPanel;


    public HealthUI healthUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        healthUI.SetMaxHearts(maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy)
        {
            TakeDamage(enemy.damage);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthUI.UpdateHearts(currentHealth);

        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

        if(currentHealth <= 0)
        {
            //player up bein unalived #quirky
            Debug.Log("Player died");

            gameOverPanel.SetActive(true); //SHOW GAME OVER

            Time.timeScale = 0f; //pause game 
        }
    }
}
