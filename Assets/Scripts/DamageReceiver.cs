using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField] protected int hp = 10;

    public virtual bool isDead()
    {
        return this.hp <= 0;
    }

    public virtual void Receiver(int damage)
    {
        this.hp -= damage;
    }
}
