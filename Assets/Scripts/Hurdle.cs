using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdle : MonoBehaviour
{
    float hurdleSpeed; // 장애물의 이동속도

    private void Start()
    {
        hurdleSpeed = -DataManager.getInstance.speed; //datamanager에서 이동속도를 가져옴
    }
    void Update()
    {
        transform.Translate(hurdleSpeed * Time.deltaTime,0,0);  //x축으로 hurdleSpeed * 프레임 사이의 시간간격 만큼 이동
    }
   void OnTriggerEnter2D(Collider2D collision) // 트리거 발동신호
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어면
        {
            DataManager.getInstance.HP--; //체력감소
            Debug.Log(DataManager.getInstance.HP);//남은 체력 로그
        }
    }
}
