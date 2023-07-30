using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefab : MonoBehaviour
{
    protected List<GameObject> enemies;
    protected int maxEnemies = 1;
    protected GameObject enemyPrefab;
    protected float time = 0f;
    protected float delay = 1f;
    public GameObject enemyPrefabPos;

    private void Awake()
    {
        this.enemyPrefab = GameObject.Find("Enemy Prefab");
        this.enemyPrefabPos = GameObject.Find("EnemyPrefabPos");
        this.enemyPrefab.SetActive(false);

        this.enemies = new List<GameObject>();
    }

    // Update is called once per frame
    private void Update()
    {
        this.checkDead();
        this.spawn();

    }

    protected virtual void spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.isDead()) return;

        if (this.enemies.Count >= this.maxEnemies) return;

        this.time += Time.deltaTime;
        if (this.time < delay) return;
        this.time = 0f;

        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = this.enemyPrefabPos.transform.position;
        enemy.transform.parent = transform;


        enemy.SetActive(true);

        this.enemies.Add(enemy);
    }

    void checkDead()
    {
        GameObject enemy;
        for (int i = 0; i < this.enemies.Count; i++)
        {
            enemy = this.enemies[i];
            if (enemy == null)
            {
                this.enemies.RemoveAt(i);
            }
        }
    }
}
