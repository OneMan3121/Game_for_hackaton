using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPanel : MonoBehaviour
{

public void Onclick()
    {
        transform.parent.transform.parent = null;
    }
}
