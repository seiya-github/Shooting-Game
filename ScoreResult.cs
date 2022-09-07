using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    //スコアテキスト
    public Text ScoreText;
    //スコア
    int score;

    // Start is called before the first frame update
    void Start()
    {
        //取得した値をスコアに代入
        score = ScoreController.getscore();
        //スコア表示
        ScoreText.text = string.Format("{0}",score);
        
    }

}
