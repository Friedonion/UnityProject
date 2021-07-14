using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;


[Serializable] // 직렬화
public class MapD
{
    public float time; // 몇 초 뒤에 생성할 것인가 
    public int number; //생성할 장애물 번호
    public int point;  // 위 아래
}

[Serializable]
public class MapData
{
    public int len; // 장애물 개수
    public List<MapD> map;  //장애물 배열
}




public class JsonMap :MonoBehaviour
{
    MapData mapData;
    public GameObject[] spawnPoints = new GameObject[2]; //생성장소
    public GameObject[] gameObjects; //장애물 프리팹
    public int level; //레벨
    int i=0; //몇번째 장애물
    float timer = 0;
  
    public void getData(string path, string file_name) // 맵 파일을 불러오는 함수
    {
        FileStream fileStream = new FileStream(string.Format("{0}/{1}.json", path, file_name), FileMode.Open);
        byte[] data = new byte[fileStream.Length];
        fileStream.Read(data, 0, data.Length);
        fileStream.Close();
        string json_board_data = Encoding.UTF8.GetString(data);
        mapData = JsonUtility.FromJson<MapData>(json_board_data);
    }
    void Start()
    {
        getData(Application.dataPath + "/levelData", "Map_" + level);
    }
  
    void Update()
    {
        timer += Time.deltaTime; //이전 장애물을 생성한 이후의 시간
        if(timer >= mapData.map[i].time) // 장애물을 생성할 시간이 되면
        {
            if (i < mapData.len)
            {
                Instantiate(gameObjects[mapData.map[i].number], spawnPoints[mapData.map[i].point].transform.position, Quaternion.identity); // 동적으로 오브젝트를 spawnPoints 위치에 생성함
                i++; // 다음 장애물
                timer = 0; // 시간 초기화
            }
        }
    }
}
