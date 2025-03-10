using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    private static BasicEnemy Enemy;
    private int health;
    private int attack;
    private int defence;
    private BasicEnemy()
    {
        health = 15;
        attack = 2;
        defence = 3;
    }


    public static BasicEnemy get()
    {
        if(Enemy == null)
        {
            Enemy = new BasicEnemy();
        }
        return Enemy;
    }
}
