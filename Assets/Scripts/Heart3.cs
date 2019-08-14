using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart3 : MonoBehaviour
{
    public GameObject Player;
    private Health access;

    // Start is called before the first frame update
    void Start()
    {
        access = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (access.currentHealth<3)
        {
            Destroy(gameObject);
        }
    }
}
