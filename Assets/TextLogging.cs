using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLogging : MonoBehaviour
{
    public Text TextTolog;
    public float TimerForInstantiateText;
    // Start is called before the first frame update
    void Start()
    {
        TextTolog.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {    
            TimerForInstantiateText -= Time.deltaTime;
            if(TimerForInstantiateText<=0)
            {
                TextTolog.enabled = true;
                
            }           
    }
}

