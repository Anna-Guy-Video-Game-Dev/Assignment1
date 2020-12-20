using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    float xScale;
    [SerializeField] float minScale;
    [SerializeField] float maxScale;
    [SerializeField] Vector3 rotation;

    void Start()
    {
        xScale = 0;
    }

    void Update()
    {
        scale();
        rotate();
    }

    void clamp(ref float val, int min, int max)
    {
        if (val > max)
            val = max;
        else if (val < min)
            val = min;

    }
    void scale()
    {
        float step = 0.5f;

        if (transform.localScale.x<minScale)
            step = 0.5f;

        else if (transform.localScale.x > maxScale)
            step = -0.5f;

        xScale += step;
        transform.localScale += new Vector3(xScale * Time.deltaTime, 0, 0);
    }
    void rotate()
    {
        transform.Rotate(rotation);
    }

}
