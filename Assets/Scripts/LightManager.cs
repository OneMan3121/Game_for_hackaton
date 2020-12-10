using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LightManager 
{

    private static GameObject[] Lights = GameObject.FindGameObjectsWithTag("Light");
    public static GameObject globalLight = GameObject.FindGameObjectWithTag("GlobalLight");

        public static void TurnOnLight()
    {
        for(int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(false);
            
        }
        globalLight.GetComponent<Light>().intensity = 1.3f;
    }

    public static void TurnOffLight()
    {
        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(true);
        }
        globalLight.GetComponent<Light>().intensity = 0.0f;
    }


}
