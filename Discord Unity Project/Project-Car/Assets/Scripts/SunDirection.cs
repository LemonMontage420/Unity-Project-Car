using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDirection : MonoBehaviour
{
    public Material skybox;

    public Transform sun;
    public Transform moon;

    [Range(0, 1440)]
    public float timeOfDay;

    public Gradient horizonColorGradient;
    public Gradient skyColorGradient;

    public AnimationCurve starPowerCurve;
    public AnimationCurve starSizeCurve;

    void Update()
    {
        transform.rotation = Quaternion.Euler(timeOfDay / 4, transform.rotation.y, transform.rotation.z);

        skybox.SetVector("_SunDirection", sun.forward);
        skybox.SetVector("_MoonDirection", moon.forward);
        skybox.SetColor("Color_D57026B", horizonColorGradient.Evaluate(timeOfDay / 1440));
        skybox.SetColor("Color_ABAE7C8E", skyColorGradient.Evaluate(timeOfDay / 1440));
        skybox.SetFloat("Vector1_D26596D4", starPowerCurve.Evaluate(timeOfDay / 1440));
        skybox.SetFloat("Vector1_1E5703F0", starSizeCurve.Evaluate(timeOfDay / 1440));
    }
}
