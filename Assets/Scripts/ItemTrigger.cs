using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTrigger : MonoBehaviour
{
    public bool isfind = false;

    private Light light;
    private GameObject button_use;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponentInChildren<Light>();
        light.enabled = false;
        button_use = GameObject.FindGameObjectWithTag("Button_Use");

    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isfind = true;
            light.enabled = true;
            button_use.GetComponent<Button>().interactable = true;
            button_use.GetComponentInChildren<Text>().color = new Color(255, 255, 255, 255);
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isfind = true;
            light.enabled = false;
            button_use.GetComponent<Button>().interactable = false;
            button_use.GetComponentInChildren<Text>().color = new Color(255, 255, 255, 0);
        }
    }

}
