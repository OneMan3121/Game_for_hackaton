using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemTriggerManager
{
    private static GameObject[] global_evidence = GameObject.FindGameObjectsWithTag("evidence");
    private static GameObject[] evidence = GameObject.FindGameObjectsWithTag("evidence");

    public static int getGlobalEvidenceCount()
    {
        return global_evidence.Length;

    }
    public static int getEvidenceCount()
    {
        evidence = GameObject.FindGameObjectsWithTag("evidence");
        return evidence.Length;
    }
    public static bool deleteFindedEvidence()
    {
        evidence = GameObject.FindGameObjectsWithTag("evidence");
        for (int i = 0; i < evidence.Length; i++)
        {
            ItemTrigger it = evidence[i].GetComponent<ItemTrigger>();
           if (it.isfind)
            {
                it.isfind = false;
                MonoBehaviour.Destroy(it.gameObject);
                return true;
            }
        }
        return false;
    }


}
