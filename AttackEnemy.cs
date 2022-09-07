using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    //敵の弾
    public GameObject shellPrefab;
    //効果音
    public AudioClip sound;
    //カウント
    private int count;
    //ターゲット
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //名前でオブジェクトを特定させる。
        target = GameObject.Find("Player_Character");
    }

    // Update is called once per frame
    void Update()
    {
        //弾の生成数
        count += 1;

        //60フレームごとに砲弾を発射する
        if(count % 60 == 0)
        {
            //弾を生成
            GameObject shell = Instantiate(shellPrefab,transform.position,Quaternion.identity);
            
            //衝突判定
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            //弾速設定
            shellRb.AddForce(transform.forward * 500);

            //発射音を出す
            AudioSource.PlayClipAtPoint(sound, transform,position);

            //５秒後に弾を破壊
            Destroy(shell,5.0f);
        }

         //もしこのGameObjectがタグ名「Bullet」のGameObjectに衝突したら
        if(gameObject.tag == "Bullet")
        {
            //このGameObjectは消滅する
            Destroy(this.gameObject);
            
        }
        
        //「LookAtメソッド」の活用　＝　自動追尾
        this.gameObject.transform.LookAt(target.transform.position);
    }
}
