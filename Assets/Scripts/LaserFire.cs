using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour
{
    public float velocityX=5f;
    float velocityY = 0f;
    Rigidbody2D rb;
    Transform tr;
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        InvokeRepeating("Fire", 0.00f, 5.00f);
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, velocityY);   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }

    void Fire()
    {
        tr.position = new Vector3(x, y, 0);
        gameObject.SetActive(true);
    }
}
