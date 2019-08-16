using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Collectible : MonoBehaviour
{
    public int currentScore = 0;
    public Text countText;
    Transform tr;
    float[,] locations=new float[4, 3] { { 5.23f, -5.31f, 0 }, { -4.891f, -0.272f, 0 }, { 5.35f, -2.34f, 0 }, {2.02f,-0.46f, 0 } };
    int num;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            currentScore++;
            randomPosition();
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = currentScore.ToString();
    }

    void randomPosition()
    {
        int old = num;
        System.Random random = new System.Random();
        num = random.Next(4);
        if (old == num)
        {
            randomPosition();
        }
        else
        {
            tr.position = new Vector3(locations[num, 0], locations[num, 1], 0);
            gameObject.SetActive(true);
        }
    }
}
