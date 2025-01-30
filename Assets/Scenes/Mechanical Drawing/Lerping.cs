using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    public AnimationCurve curve;
    // Declaring the range of the lerp, as well as the values of the different variables 
    [Range(0, 2)]
    float t = 0f;
    public float speed = 1f;
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        transform.position = Vector3.Lerp(start.position, end.position, curve.Evaluate(t));
        if(t > 1.99f) // Makes it so that when t exceeds 1.99, the lerp resets.
        {
            t = 0f;
        }
    }
}
