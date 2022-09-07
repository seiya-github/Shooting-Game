using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //GameObject型の変数explosionを外部から参照可能と宣言
    public GameObject explosion;
    //効果音設定
    public AudioClip sound;

    //これが敵を倒すと得られる点数になる
    
    //int型の変数scoreValueを外部から参照可能と宣言
    public int scoreValue;
    //ScoreControllerをscに代入し、外部から参照不可と宣言
    private ScoreController sc;

    // Start is called before the first frame update
    void Start()
    {
        //「ScoreManagerオブジェクト」についている「ScoreControllerスクリプト」の情報を取得して「sc」箱に入れる。
        sc = GameObject.Find("ScoreManager").GetComponent<ScoreController>();
    }

    //メソッドの定義（物体がすり抜けた時）
    private void OnTriggerEnter(Collider col)
    {
        //もし弾が当たったら
        if(col.gameObject.tag == "Bullet")
        {
            
            //消滅する
            Destroy(this.gameObject);

            //消滅エフェクト
            Instantiate(explosion.gameObject, this.transform.position, Quaternion.identity);

            // 効果音を出す
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

            //得点が加算される
            sc.AddScore(scoreValue);
        }
    }
}