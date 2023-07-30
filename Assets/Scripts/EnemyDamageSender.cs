using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSender : DamageReceiver
{
    public EnemyCtrl enemyCtrl;

    public int damage = 1;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset()
    {
        this.hp = 3;
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();


        if (damageReceiver == null) return;

        base.Receiver(this.damage);

        if (this.isDead()) this.enemyCtrl.despawner.Despawn();

        Debug.Log("vacham");

    }

}
