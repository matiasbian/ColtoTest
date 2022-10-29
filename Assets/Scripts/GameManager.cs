using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    static int initialLifes = 2;
    public static int life = 2;
    static int remainingEnemies = 10;
    public static int ENEMIES_AMOUNT = 10;
    public static Action lose;
    public static Action win;
    public static Action gameOver;
    
    public static void LoseLife () {
        life --;
        if (life < 0) {
            gameOver?.Invoke();
        } else {
            lose?.Invoke();
        }
    }

    public static void EnemyDestroyed () {
        remainingEnemies -=1;
        if (remainingEnemies == 0) Win();
    }

    static void Win () {
        win?.Invoke();
    }

    public static void ResetLifes () {
        life = initialLifes;
    }
}
