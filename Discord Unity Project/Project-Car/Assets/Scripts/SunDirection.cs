﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDirection : MonoBehaviour
{
    public Material skybox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skybox.SetVector("_SunDirection", transform.forward);
        Debug.Log(skybox.GetVector("_SunDirection"));
    }
}
