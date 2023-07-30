using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;
    protected IUManager uManager;

    private void Awake()
    {
           this.playerCtrl = GetComponent<PlayerCtrl>();
           
    }

    public virtual void Dead()
    {
        Debug.Log("Dead!!");
    }
}
