using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRespawn : MonoBehaviour
{
    public GameObject respawnPoint;
    public float deadDepth = -100f;

    [SerializeField] private bool gameOver;
    public GameObject gameOverScreen;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        name = gameObject.name;

        Debug.Log("hello from " + name); 
        Debug.Log(" - dead depth: " + deadDepth);

        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y <= deadDepth) {

            gameOver = true;

        } 
        
        if (gameOver) {

            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);

        }

        if (gameOver && Input.GetKeyDown("r")) {

            Time.timeScale = 1f;
            gameOver = false;
            gameOverScreen.SetActive(false);
            SendToRespawn();

        }

    }

    void SendToRespawn() {

        transform.position = respawnPoint.transform.position;
        rb.velocity = Vector3.zero;

    }

    void OnTriggerEnter(Collider other) {

        if (other.transform.parent) {

            if (LayerMask.NameToLayer("Respawn") == other.gameObject.layer) {

                respawnPoint = other.transform.parent.gameObject;

            }

        }

    }

    void OnCollisionEnter(Collision other) {

        if (other.gameObject.GetComponent<Kill>()) {

            SendToRespawn();

        }

    }

}
