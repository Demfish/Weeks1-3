using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LerpDemo : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;
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
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
