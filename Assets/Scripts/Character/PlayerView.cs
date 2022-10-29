using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : BaseView
{
    // Start is called before the first frame update
    protected override void Init()
    {
        base.Init();
    }

    // Update is called once per frame
    protected override void OnUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        controller.Move(x,y);
        
        if (Input.GetButtonDown("Fire1")) {
            controller.Shoot();
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.collider.transform.CompareTag("Enemy")) {
            GameManager.LoseLife();
        }
    }
}
