using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFromPool : MonoBehaviour
{

    public GameObject generator;
    [SerializeField] private ObjectPool op;

    public float cooldownTime = 5f;
    public float timestamp;
    public bool canSpawn = true;

    public GameObject timeCenter;
    private TimeFlowCenter tfc;
    public bool slowdownAttribute = true;
    [SerializeField] private float timeScalePlus;

    // Start is called before the first frame update
    void Start()
    {
        
        canSpawn = true;
        op = generator.GetComponent<ObjectPool>();

        tfc = timeCenter.gameObject.GetComponent<TimeFlowCenter>();
        
        if (slowdownAttribute) {

            timeScalePlus = 100 / (tfc.timeScale * 100);

        } else {

            timeScalePlus = 1f;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject bullet = op.GetPooledObject();

        if (Time.time >= timestamp + (cooldownTime * timeScalePlus) && tfc.activated) {

            canSpawn = true;

        } else if (Time.time > timestamp + cooldownTime && !tfc.activated) { 
            
            canSpawn = true; 
        
        }

        if (bullet != null && canSpawn) {

            //Debug.Log("shot!");
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.SetActive(true);

            Cooldown();

        }

    }

    void Cooldown(){

        canSpawn = false;

        timestamp = Time.time;

    }

}
