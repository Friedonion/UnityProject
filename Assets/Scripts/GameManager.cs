using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ClearUI = new GameObject[2];
    void Update()
    {
        if(DataManager.getInstance.HP<=0)
        {
            ClearUI[0].SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void clear()
    {
        ClearUI[1].SetActive(true);
    }
}
