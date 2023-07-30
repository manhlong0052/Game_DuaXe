using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject roadPrefabPos;
    public float distance = 0;
    public GameObject roadCurrent;
    public int roadLayerOder = 0;

    private void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadPrefabPos = GameObject.Find("RoadPrefabPos");
        this.roadPrefab.SetActive(false);

        this.roadCurrent = this.roadPrefab;
        this.roadLayerOder = (int) this.roadPrefab.transform.position.z;
        this.Spawn(this.roadPrefab.transform.position);
    }

    private void FixedUpdate()
    {
        this.updateRoad();
    }

    protected virtual void updateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position, this.roadCurrent.transform.position);
        if (this.distance > 40
            )
        {
            this.Spawn();
        }
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadPrefabPos.transform.position;
        pos.x = 0f;
        pos.z = this.roadLayerOder;

        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.roadCurrent.transform.parent = transform;
        this.roadCurrent.SetActive(true);
    }
}
