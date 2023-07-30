using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadDespawner : MonoBehaviour
{
    protected  float distance = 0;

    private void FixedUpdate()
    {
        this.updateRoad();
    }

    protected virtual void updateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, transform.position);
        if (this.distance > 70
            )
        {
            this.Despawn();
        }
    }


    protected virtual void Despawn()
    {
        Destroy( this.gameObject );
    }
}
