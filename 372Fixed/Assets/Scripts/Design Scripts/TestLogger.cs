using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLogger : MonoBehaviour
{
    static void Main()
    {
        //Logger obj1 = new Logger();
        //Logger obj2 = new Logger();
        Logger obj1 = Logger.GetInstance();
        Logger obj2 = Logger.GetInstance();
        Console.WriteLine(obj1.GetHashCode());
        Console.WriteLine(obj2.GetHashCode());

    }
}
