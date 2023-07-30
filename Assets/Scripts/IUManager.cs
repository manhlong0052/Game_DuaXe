using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUManager : MonoBehaviour
{
    public GameObject bnGameOver;
    static public IUManager instance; 

    private void Awake()
    {
        IUManager.instance = this;

        this.bnGameOver = GameObject.Find("bnGameOver");
        this.bnGameOver.SetActive(false);
    }
}
