using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.005f;

        transform.position = nextPosition;
    }
}
