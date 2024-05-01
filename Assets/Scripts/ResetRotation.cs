using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), 100f * Time.deltaTime);
        if (transform.rotation == Quaternion.Euler(0, 0, 0))
            enabled = false;
    }
}
