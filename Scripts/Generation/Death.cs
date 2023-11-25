using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject respawnPoint;
    public float deadDepth = -100f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        name = gameObject.name;

        //Debug.Log("hello from " + name); 
        //Debug.Log(" - dead depth: " + deadDepth);

        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y <= deadDepth) {

            Deactivate();

        }

    }

    void Deactivate() {

        rb.velocity = Vector3.zero;
        gameObject.SetActive(false);

    }
    
}
