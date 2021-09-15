using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightAndNight : MonoBehaviour
{
    Light2D lightController;
    public bool DayOff;
    void Start()
    {
        lightController = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DayAndNight());
    }

    IEnumerator DayAndNight(){

        if(lightController.intensity > 1.24f){
            DayOff = true;
        }
        else if(lightController.intensity < 0.26f){
            DayOff = false;
        }

        yield return new WaitForSeconds(60);
           
            if(DayOff)
            {
                lightController.intensity -= 0.0002f;
            }

        yield return new WaitForSeconds(60);
            
            if(!DayOff)
            {
                lightController.intensity += 0.0002f;
            }
    }   
}
