using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private GlobalController global;

    private void Awake()
    {
        global = GlobalController.instance;
        global.obstacleList.Add(this.gameObject); 
    }

    private void OnDestroy()
    {
        Debug.Log("Cleared this obstacle");
    }
}