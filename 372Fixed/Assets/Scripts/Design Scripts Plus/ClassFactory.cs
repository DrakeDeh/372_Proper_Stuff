using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class ClassFactory : MonoBehaviour
{
    public static Classes GetClass(int Id)
    {
        Classes help = null;

        if (Id == 1)
        {
            help = new Warrior();
        }
        else if(Id == 2)
        {
            help = new Ranger();
        }
        else if(Id == 3)
        {
            help = new Mage();
        }
        else
        {
            help = new Summoner();
        }

        return help;
    }

    
}
