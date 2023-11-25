using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveSpawnRadius : MonoBehaviour
{

    public GameObject objectGenerator;
    private ObjectPool generator;

    // Start is called before the first frame update
    void Start()
    {

        generator = objectGenerator.gameObject.GetComponent<ObjectPool>();
        generator.radius = StaticSpawnRadius.spawnRadius;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
