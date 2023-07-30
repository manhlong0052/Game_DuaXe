using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtrl playerCtrl;


    private void Awake()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }
        
    public override void Receiver(int damage)
    {
        base.Receiver(damage);
        if (this.playerCtrl.damageReceiver.isDead()) { 
            this.playerCtrl.status.Dead();
            IUManager.instance.bnGameOver.SetActive(true);
        }
    }
}
