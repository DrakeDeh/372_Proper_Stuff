using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Logger : MonoBehaviour
{
    private static Logger logger;
    private int health;
    private Logger()
    {
        health = 90;
    }

    public static Logger GetInstance()
    {
        if(logger == null)
        {
            logger = new Logger();
        }
        return logger;
    }

}
