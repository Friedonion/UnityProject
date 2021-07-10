using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// singleton을 사용한 DataManager
public class DataManager : MonoBehaviour
{
    public static DataManager instance; // 어디서나 접근 가능한 static instance
    public static DataManager getInstance //instance에 접근하기위함
    {
        get 
        {
            return instance;
        }
    }
    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    public float speed = 10;
    public int score = 0;
    public int HP = 2;
}
