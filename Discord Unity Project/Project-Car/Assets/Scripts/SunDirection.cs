using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDirection : MonoBehaviour
{
    public Material skybox;

    public Transform sun;
    public Transform moon;

    void Update()
    {
        skybox.SetVector("_SunDirection", sun.forward);
        skybox.SetVector("_MoonDirection", moon.forward);
    }
}
