using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Use : MonoBehaviour
{
    public void OnClick()
    {
        ItemTriggerManager.deleteFindedEvidence();
    }

    
}
