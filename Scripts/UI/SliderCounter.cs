using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderCounter : MonoBehaviour
{

    public GameObject me;
    TextMeshProUGUI myText;

    public Slider slider;
    public float max;

    // Start is called before the first frame update
    void Start()
    {
        
        myText = me.gameObject.GetComponent<TextMeshProUGUI>(); 

    }

    // Update is called once per frame
    void Update()
    {

        int value = (int) (slider.value * max);

        myText.text = value.ToString();
        
    }
}
