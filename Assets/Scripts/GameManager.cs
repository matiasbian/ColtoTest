using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    static int life = 2;
    static int remainingEnemies = 10;
    public static int ENEMIES_AMOUNT = 10;
    public static Action lose;
    
    public static void LoseLife () {
        life --;
        lose?.Invoke();
    }

    public static void EnemyDestroyed () {
        remainingEnemies -=1;
        if (remainingEnemies == 0) Win();
    }

    static void Win () {

    }
}
