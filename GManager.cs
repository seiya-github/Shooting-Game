using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    //外部から参照可能
    public static GManager instance = null;
    //スコア
    public int score;

    //インスタンス化された瞬間に呼ばれるメソッド（初期化）
    private void Awake()
    {
        //もしインスタンスがなかったら
        if(instance == null)
        {
            //指定したものをインスタンス化
            instance = this;
            //破棄したくないオブジェクトを指定
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //消滅する
            Destroy(this.gameObject);
        }
    }
}
