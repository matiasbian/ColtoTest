using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 dir;
    public float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }

    public void SetShootDirection (float x, float y) {
        dir = new Vector2(x,y);
        float xAngle = 90 * x;
        float yAngle = xAngle * (0.5f * y);
        transform.eulerAngles = new Vector3(0,0, xAngle + yAngle);
    }

    void OnTriggerEnter2D (Collider2D col) {
        Debug.Log(col.transform.name + " my " + transform.name);
        Pooling.Get().DestroyBullet(this);
    }
}
