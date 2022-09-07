using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //効果音設定
    public AudioClip sound;
    
    // Start is called before the first frame update
    void Start()
    {
        //5秒後にこのGameObjectは消滅する
        Destroy(this.gameObject,5);
    }

    // Update is called once per frame
    void Update()
    {
        //弾は前方に発射
        transform.position += transform.TransformDirection(Vector3.forward * 2f);
        
    }

    //メソッドの定義（物体がすり抜けた時）
    void OnTriggerEnter(Collider col)
    {
        //もしこのGameObjectがタグ名「Enemy」のGameObjectに衝突したら
        if(col.gameObject.tag == "Enemy")
        {
            //このGameObjectは消滅する
            Destroy(this.gameObject);
        }

        // 効果音を出す
        AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);

        //もしこのGameObjectがタグ名「Enemy」のGameObjectに衝突したら
        // if(col.gameObject.tag == "Enemy_Bullet")
        // {
        //     //このGameObjectは消滅する
        //     Destroy(this.gameObject);
            
        // }
    }

}
