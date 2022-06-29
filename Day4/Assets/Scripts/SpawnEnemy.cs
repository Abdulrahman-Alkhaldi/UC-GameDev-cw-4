using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject obstaleb;
    void Spawn()
    {   /*
        GameObject spawnObject;
        int choice = Random.Range(0, 2);
        if (choice == 1) ;
        */
        int newPos = Random.Range(-1, 2);
        Vector3 pos = transform.position;
        pos.x = pos.x + (5 *newPos);

        GameObject newSpamn = Instantiate(obstaleb,pos,Quaternion.identity);

    }
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
