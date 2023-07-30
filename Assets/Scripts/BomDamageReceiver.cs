using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomDamageReceiver : DamageReceiver
{
    public EnemyCtrl enemyCtrl;

    public int damage = 1;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset()
    {
        this.hp = 1;
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();


        if (this.isDead()) 
        {
            Destroy(gameObject);
            EffectManager.Instance.spawnVFX("Explosion_A", transform.position, transform.rotation);   
        }

        base.Receiver(this.damage);
        Debug.Log("bom no");

    }
}
