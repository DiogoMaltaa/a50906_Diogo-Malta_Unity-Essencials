using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{

    public Vector3 scaleChange;
    public Vector3 rotationChange;
    public Vector3 transformChange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationChange);
        transform.localScale += scaleChange;
        transform.localPosition += transformChange;
    }
}
