using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;

    public DamageReceiver damageReceiver;
    public PlayerStatus status;

    private void Awake()
    {
        PlayerCtrl.instance = this;

        this.damageReceiver = GetComponent<DamageReceiver>();
        this.status = GetComponent<PlayerStatus>();
    }
}
