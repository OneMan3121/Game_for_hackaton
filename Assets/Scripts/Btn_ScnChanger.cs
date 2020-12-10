using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_ScnChanger : MonoBehaviour
{
    public string SceneName = "none";
    public Color color = Color.red;
    public float speed = 0.5f;

    // Update is called once per frame
    public void changeScene(int ScaneBuildIndex)
    {
        Debug.Log("Here Bicth!11!1!");
        Initiate.Fade("Level_1", color, speed);
    }




}
