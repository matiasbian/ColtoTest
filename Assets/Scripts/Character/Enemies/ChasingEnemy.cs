using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingEnemy : BaseView
{
    public PlayerView player;
    Vector2 dir;
    public int randomDelay;
    // Start is called before the first frame update

    // Update is called once per frame
    protected override void Init()
    {
        base.Init();
        randomDelay = Random.Range(1, 9);
    }
    float count;
    protected override void OnUpdate()
    {
        count += Time.time;
        controller.Move(dir.x, dir.y);

        if (!CanEnterInCycle(randomDelay)) return;
        bool idleChances = Random.Range(0,100) < 25;
        dir = idleChances ? Vector2.zero : (player.transform.position - transform.position).normalized;
    }

    public bool CanEnterInCycle (float multiplier = 1) => (Mathf.CeilToInt(Time.frameCount * Time.deltaTime * 15)) % (20 * Mathf.RoundToInt(multiplier)) == 0;

    void OnTriggerEnter2D (Collider2D col) {
        if (col.transform.CompareTag("Bullet")) Destroy(gameObject);
    }
}