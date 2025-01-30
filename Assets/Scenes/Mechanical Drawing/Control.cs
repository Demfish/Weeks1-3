using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour

{
    public float speed = 5; // Speed of the ships movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0); // Horizontal Keyboard Movement
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0); // Vertical Keyboard Movement
    }
}
