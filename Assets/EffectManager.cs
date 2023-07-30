using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    static public EffectManager Instance;
    public List<GameObject> effects;

    private void Awake()
    {
        EffectManager.Instance = this;
        this.thisEffect();
    }

    protected virtual void thisEffect()
    {
        this.effects = new List<GameObject>();
        foreach (Transform child in transform)
        {
            this.effects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void spawnVFX(string effectName, Vector3 position, Quaternion rot)
    {
        GameObject effect = this.getEffect(effectName);
        GameObject newEffect = Instantiate(effect, position, rot);
        newEffect.gameObject.SetActive(true);
    }

    protected virtual GameObject getEffect(string effectName)
    {
        foreach (GameObject child in this.effects)
        {
            if (child.name == effectName) return child;
        }
        return null;
    }
}
