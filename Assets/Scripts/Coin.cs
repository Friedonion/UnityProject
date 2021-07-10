using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float coinSpeed;
    public int coinScore = 2; // 획득할 점수
    private void Start()
    {
        coinSpeed = -DataManager.getInstance.speed;
    }
    void Update()
    {
        transform.Translate(coinSpeed * Time.deltaTime, 0, 0);
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DataManager.getInstance.score += coinScore; //점수 증가
            Debug.Log(DataManager.getInstance.score);
            Destroy(gameObject); // 코인은 획득하면 사라지도록
        }
    }
}
