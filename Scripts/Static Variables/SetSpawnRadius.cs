using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSpawnRadius : MonoBehaviour
{

    public Slider slider;
    public int max;

    // Update is called once per frame
    public void Update()
    {

        StaticSpawnRadius.spawnRadius = (int) (slider.value * max);

        if (StaticSpawnRadius.spawnRadius <= 0) {

            StaticSpawnRadius.spawnRadius = 1;

        }
        
    }

}
