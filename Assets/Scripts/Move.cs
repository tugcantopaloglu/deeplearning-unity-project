using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform transform;
    public float speed;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
