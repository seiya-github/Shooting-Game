using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry_Button : MonoBehaviour
{
    //リトライボタンを押したら
    public void Retry()
    {
        //「3d_shooting_No. 1」に遷移する。
        SceneManager.LoadScene("3d_shooting_No. 1");
        
        //スコアを０にする　（スコアリセット）
        ScoreController.score = 0;
    }
}
