using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float rangePlayer = 1f;
    public float enemySpeed = 7f;
    public float roadPos = 0;


    private void Awake()
    {
        this.player = PlayerCtrl.instance.transform;

        this.roadPos = Random.Range(-6, 6);
    }

    private void FixedUpdate()
    {
        this.flow();
    }

    void flow()
    {

        Vector3 pos = this.player.transform.position;

        pos.x = this.roadPos;

        Vector3 distance = pos - transform.position;

        if (distance.magnitude >= rangePlayer)
        {
            Vector3 targetPoint = pos - distance.normalized * rangePlayer;

            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, enemySpeed * Time.deltaTime);
        }
    }
}
