using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    static int life = 2;
    public static Action lose;
    
    public static void LoseLife () {
        life --;
        lose?.Invoke();
    }
}
