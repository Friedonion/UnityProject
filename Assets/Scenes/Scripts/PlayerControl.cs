using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour 
{
    private int jump = 2; // 점프 횟수를 나타내는 변수
    public float jumpSpeed = 10; //점프 스피드
    void Update() // 매 프레임 마다 실행
    {
        if(Input.GetKeyDown(KeyCode.Space)) // 스페이스바를 눌렀을때 실행
        {
            if (jump > 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpSpeed);  //Rigidbody2D 컴포넌트를 가져와 y축방향의 속력을 지정
                jump--;
            }
        }  
    }
    void OnCollisionEnter2D(Collision2D other) //다른2D collider와 충돌하면 한 번 실행, 충돌한 collider를 other이라는 매개변수로 받음 
    {
        Debug.Log(other.gameObject.name); // Unity 콘솔에 충돌한 물체 이름 출력, 제대로 실행되고 있는지 확인하는 용도
        if (other.gameObject.tag == "Plane") 
        {
            jump = 2; //Plane 태그를 가진 오브젝트와 충돌하면 jump횟수 초기화
        }
    }
}
