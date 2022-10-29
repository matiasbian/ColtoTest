using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public ChasingEnemy prefab;
    public PlayerView player;
    public int enemiesAmount;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies () {
        Camera main = Camera.main;
        Vector2 min = main.ScreenToWorldPoint(Vector2.zero);
        Vector2 max = main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        for (int i = 0; i < enemiesAmount; i++) {
            Vector2 randomPos = player.transform.position;
            while (Vector2.Distance(player.transform.position, randomPos) < 2f) randomPos = new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
            var enem = Instantiate<ChasingEnemy>(prefab, randomPos, prefab.transform.rotation, transform);
            enem.player = player;
        }
    }
}
