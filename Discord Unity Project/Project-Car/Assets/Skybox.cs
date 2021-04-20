using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Skybox : MonoBehaviour
{
    public Material skyboxMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skyboxMaterial.GetFloat("_RadiusB") >= skyboxMaterial.GetFloat("_RadiusA"))
        {
            skyboxMaterial.SetFloat(("_RadiusB"), skyboxMaterial.GetFloat("_RadiusA") - 0.001f);
        }
    }
}
