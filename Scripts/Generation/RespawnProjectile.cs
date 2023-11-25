using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnProjectile : MonoBehaviour
{
    public GameObject respawnPoint;
    public float deadDistance = 100f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        name = gameObject.name;

        Debug.Log("hello from " + name); 
        Debug.Log(" - dead distance: " + deadDistance);

        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(transform.position, respawnPoint.transform.position) > deadDistance) {

            SendToRespawn();

        }

    }

    void OnCollisionEnter(Collision other) {

        SendToRespawn();

    }

    void SendToRespawn() {

        transform.position = respawnPoint.transform.position;
        rb.velocity = Vector3.zero;
        gameObject.SetActive(false);

    }

}
