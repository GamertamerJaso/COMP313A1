using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Make Transform Accessible
    Transform tr;
    // Make Sphere Accessible
    // Object Speed
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // Access Object Transform
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // State x = Horizontal Input
        var x = Input.GetAxisRaw("Horizontal") * (speed);
        var y = Input.GetAxisRaw("Vertical") * (speed);
        // By accessing transform we replace the x with our x
        tr.Translate(x, 0, 0);
        tr.Translate(0, y, 0);
    }


   
}
