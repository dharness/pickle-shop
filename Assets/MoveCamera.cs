using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float fromZ;
    public float toZ;
    public float speed;
    float direction = 1;

    public void Update()
    {
        if (transform.position.z > toZ) { direction = -1; }
        if (transform.position.z < fromZ) { direction = 1; }

        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z + (speed * Time.deltaTime * direction)
        );
    }
}
