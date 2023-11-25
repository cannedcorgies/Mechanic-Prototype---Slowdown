using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaWheel : MonoBehaviour
{

    public GameObject timeCenter;
    private TimeFlowCenter tfc;

    public Slider staminaWheel;
    public Slider usageWheel;

    // Start is called before the first frame update
    void Start()
    {
        
        tfc = timeCenter.gameObject.GetComponent<TimeFlowCenter>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (tfc.activated) {

            Debug.Log("GAHHHHHHHHHHH");

            usageWheel.value = tfc.charge/tfc.chargeMax + 0.05f;

        } else {

            usageWheel.value = tfc.charge/tfc.chargeMax;

        }

        staminaWheel.value = tfc.charge/tfc.chargeMax;

    }
}
