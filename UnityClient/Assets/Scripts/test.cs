using ClientLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicOnion;
using System;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Startup.Init();

        var res = Startup.Sum(1, 2);
        Console.WriteLine("SUM: " + res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
