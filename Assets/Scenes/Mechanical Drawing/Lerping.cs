using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
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
    }
}
