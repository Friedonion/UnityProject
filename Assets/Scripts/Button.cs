using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
  public void restart()
    {
        DataManager.getInstance.score = 0;
        DataManager.getInstance.HP = 3;
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameObject.scene.name);
        Time.timeScale = 1;
    }
}
