using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float Speed;
    private void Start()
    {
        Speed = -DataManager.getInstance.speed; //datamanager에서 이동속도를 가져옴
    }
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);  //x축으로 hurdleSpeed * 프레임 사이의 시간간격 만큼 이동
    }
}
