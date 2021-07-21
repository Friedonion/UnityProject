using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TextMeshProUGUI Text; 
   void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        Text.text = DataManager.getInstance.score.ToString();
    }
}
