using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += (float)0.1; // Controls the speed of the rotation of the planet, float needed for conversion
        transform.eulerAngles = rot; 
    }
}
