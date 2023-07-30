using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    public EnemyCtrl enemyCtrl;

     private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();

        Debug.Log("vacham");
    }
}
