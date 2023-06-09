using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universe : MonoBehaviour
{
    // Update is called once per frame
    public float RotateSpeed;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation",Time.time*RotateSpeed);
    }
}
