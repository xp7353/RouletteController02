using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { this.rotSpeed = 30.0f; }
        if (Input.GetMouseButtonDown(2)) { this.rotSpeed = 0.0f; }
        if (Input.GetMouseButtonDown(1)) { this.rotSpeed = -30.0f; }

        this.rotSpeed *= 0.987f;
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
