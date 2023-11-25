using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveBallsNumber : MonoBehaviour
{

    public GameObject ballsGenerator;
    private ObjectPool generator;

    // Start is called before the first frame update
    void Start()
    {

        generator = ballsGenerator.gameObject.GetComponent<ObjectPool>();
        generator.amountToPool = StaticBallsNumber.ballsNum;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
