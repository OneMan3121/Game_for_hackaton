using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
   
    public GameObject Tp_pos_1, Tp_pos_2;
    public bool swichLight = false;
    public bool isSwichedLight = false;
    private GameObject player;
     


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public IEnumerator OnTriggerTeleport(Collider2D other,GameObject who)
    {
        Debug.Log("AAAAAAAAA");
        Initiate.Fade(SceneManager.GetActiveScene().name, Color.black, 1.0f);
        yield return new WaitForSeconds(1);
        if (who == Tp_pos_1) player.transform.position = new Vector3(Tp_pos_2.transform.position.x, Tp_pos_2.transform.position.y, player.transform.position.z);
        else player.transform.position = new Vector3(Tp_pos_1.transform.position.x, Tp_pos_1.transform.position.y, player.transform.position.z);

        if (swichLight) swichLights();
      

    }
    void swichLights()
    {
        if (isSwichedLight)
        {
            LightManager.TurnOnLight();
            isSwichedLight = !isSwichedLight;
        }
        else
        {
            LightManager.TurnOffLight();
            isSwichedLight = !isSwichedLight;
        }
    }


















}
