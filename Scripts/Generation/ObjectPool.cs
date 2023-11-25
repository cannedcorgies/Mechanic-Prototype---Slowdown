using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public bool setToActive = false;
    
    public float radius = 5f;
    public Vector3 offset;

    public bool randomActivated = false;
    public int amountMin = 1;
    public int amountMax = 1;
    public int amountToPool = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        SharedInstance = this;

        offset = objectToPool.transform.position;

        if (randomActivated) { amountToPool = Random.Range(amountMin, amountMax); }
        
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++) {

            tmp = Instantiate(objectToPool);
            tmp.transform.position = offset + (Random.insideUnitSphere * radius);
            //tmp.transform.position = new Vector3(tmp.transform.position.x, tmp.transform.position.y + yOffset, tmp.transform.position.z);

            if (!setToActive) { tmp.SetActive(false); }
            pooledObjects.Add(tmp);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    public GameObject GetPooledObject()
    {

        for (int i = 0; i < amountToPool; i++) {

            if (!pooledObjects[i].activeInHierarchy)

            {

                return pooledObjects[i];

            }

            
        }
        
        return null;

    }
}
