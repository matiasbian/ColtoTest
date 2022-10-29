using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    // Start is called before the first frame update
    public Bullet bulletPrefab;
    static Pooling self;
    const int POOLING_SIZE = 30;
    Stack<Bullet> bullets = new Stack<Bullet>();
    void Start()
    {
        InitPooling();
    }

    public static Pooling Get () {
        if (self) return self;
        self = GameObject.FindObjectOfType<Pooling>();
        return self;
    }

    void InitPooling () {
        for (int i = 0; i < POOLING_SIZE; i++) {
            var instance = Instantiate<Bullet>(bulletPrefab);
            instance.transform.parent = this.transform;
            instance.gameObject.SetActive(false);
            instance.transform.name = "Bullet " + i;
            bullets.Push(instance);
        }
    }

    public Bullet InstanceBullet () {
        var bullet = bullets.Pop();
        bullet.gameObject.SetActive(true);
        return bullet;
    }

    public void DestroyBullet (Bullet bullet) {
        bullets.Push(bullet);
        bullet.gameObject.SetActive(false);
    }
}
