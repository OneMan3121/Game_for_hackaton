using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{

    private Teleporter teleporter;
    // Start is called before the first frame update
    void Start()
    {
        teleporter = GetComponentInParent<Teleporter>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(teleporter.OnTriggerTeleport(other, this.gameObject));
        }

    }
   

   
}
