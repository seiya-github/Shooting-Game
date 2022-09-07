using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAME_START : MonoBehaviour
{
    //メソッドの定義
    public void StartGame()
    {
        //「3d_shooting_No. 1」に遷移する
        SceneManager.LoadScene("3d_shooting_No. 1");
    }
    
}
