using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float RotateSpeed = 1.2f;
    public float MaxBrightness = 1;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        RenderSettings.skybox.SetFloat("_Exposure", Mathf.Abs((Time.time % 60f)-30f)/30f);
    }
}
