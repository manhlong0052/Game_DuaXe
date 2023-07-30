using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Location : MonoBehaviour
{
    float positionX;
    List<GameObject> booms;
    public GameObject boomPrefab;
    public int numberBoom = 7;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        this.booms = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.spawn();

        this.checkboomDead();
    }


    protected virtual void spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay)
        {
            return;
        }
        this.spawnTimer = 0f;

        Debug.Log("SPAWN!!!");

        if (this.booms.Count >= this.numberBoom) return;

        int index = this.booms.Count + 1;
        GameObject boom = Instantiate(boomPrefab);
        boom.name = "Boom #" + index;
        this.booms.Add(boom);

        boom.transform.position = transform.position;
        boom.SetActive(true);
    }

    void checkboomDead()
    {
        GameObject boom;
        for (int i = 0; i < booms.Count; i++)
        {
            boom = this.booms[i];
            if (boom == null)
            {
                this.booms.RemoveAt(i);
            }
        }
    }
}
