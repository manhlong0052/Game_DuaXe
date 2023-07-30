using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public Despawner despawner;
    public PlayerDamageReceiver playerDamageReceiver;


    private void Awake()
    {
        this.despawner = GetComponent<Despawner>();
        this.playerDamageReceiver = GetComponent<PlayerDamageReceiver>();
    }
}
