﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RhythmScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * -transform.forward * 2;
    }
}