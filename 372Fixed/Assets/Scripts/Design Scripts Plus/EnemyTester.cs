using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTester : MonoBehaviour
{
    
    static void main()
    {
        BasicEnemy gobo = BasicEnemy.get();
        BasicEnemy torl = BasicEnemy.get();
        Debug.Log("Hash Code 1: " + gobo.GetHashCode());
        Debug.Log("Hash Code 2: " + torl.GetHashCode());
        Console.WriteLine(gobo.GetHashCode());
        Console.WriteLine(torl.GetHashCode());

    }
}
