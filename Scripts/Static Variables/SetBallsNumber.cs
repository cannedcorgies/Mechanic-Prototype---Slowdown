using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBallsNumber : MonoBehaviour
{
    
    public Slider slider;
    public int max;

    // Update is called once per frame
    public void Update()
    {

        Debug.Log(StaticBallsNumber.ballsNum);
        StaticBallsNumber.ballsNum = (int) (slider.value * max);
        
    }

}
