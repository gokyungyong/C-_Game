using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float RotSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.RotSpeed = 10;
        }

        transform.Rotate(0, 0, this.RotSpeed);

        this.RotSpeed *= 0.96f;
    }
}
