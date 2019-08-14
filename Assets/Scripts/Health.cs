using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int currentHealth = 3;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            currentHealth--;
        }
    }

    void Die()
    {
        gameOverText.text = "Game Over";
        Destroy(gameObject);
    }
}
