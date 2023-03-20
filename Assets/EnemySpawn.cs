using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] float spawnSpeed;
    public GameObject prefabEnemy;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnTime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        
        Instantiate(prefabEnemy, GeneratedPosition(), Quaternion.identity);
    }


    Vector3 GeneratedPosition()
    {
        float x,y,z;
        x = Random.Range(4.4f,-4.4f);
        y = 0.25f;
        z = 29f;
        return new Vector3(x,y,z);
    }
    
    IEnumerator spawnTime()
    {
        while(true)
        {
        
        spawn();
        yield return new WaitForSeconds(spawnSpeed);
        }
        
    }
}
