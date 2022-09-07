using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    //スコア
    public static int score = 0;
    //スコアラベル
    private Text ScoreLabel;


    // Start is called before the first frame update
    void Start()
    {
        //スコアラベルを表示
        ScoreLabel = GameObject.Find("ScoreLabel1").GetComponent<Text>();
        //スコアを表示
        ScoreLabel.text = "" + score;
    }

    //スコアを増加させるメソッド（外部からアクセスするためpublicで定義する）
    public void AddScore(int amount)
    {
        //スコアを増加
        score += amount;
        //スコアを表示
        ScoreLabel.text = "" + score;
    }    

    //メソッドの定義(スコアを返す)
    public static int getscore()
    {
        //スコアを返す
        return score;
    }
}
