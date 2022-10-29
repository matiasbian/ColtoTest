using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public bool debug;
    CharacterModel model;
    public Direction[] directions;
    SpriteRenderer spriteRenderer;
    Vector2 lastDir = new Vector2(0, -1);
    // Start is called before the first frame update
    void Start()
    {
        model = new CharacterModel(speed, GetComponent<Animator>());
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move (float horizontal, float vertical) {
        Debug.Log(model.speed);
        transform.Translate(new Vector2(horizontal, vertical) * model.speed * Time.deltaTime);
        model.UpdateCurrentDirection(horizontal, vertical);
        if (new Vector2(horizontal, vertical) != Vector2.zero) lastDir = new Vector2(horizontal,vertical);
    }

    void Update () {
        if (debug) print (model.direction);
    }

    public void SetSprite (int index) {
        int dir = (int) model.direction;
        spriteRenderer.sprite = directions[dir].sprites[index];
    }

    public void Shoot () {
        var bullet = Pooling.Get().InstanceBullet();
        bullet.transform.position = (Vector2)transform.position + lastDir;
        bullet.SetShootDirection(lastDir.x, lastDir.y);
    }
}
