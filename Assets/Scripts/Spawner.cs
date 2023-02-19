using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject reward;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnReward),this.spawnRate,this.spawnRate);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnReward()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.value,Random.value,0));
        pos.z = 0;
        Instantiate(reward,pos,Quaternion.identity);
    }
}
