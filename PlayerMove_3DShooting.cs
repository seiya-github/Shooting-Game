using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove_3DShooting : MonoBehaviour
{
    //スピード
    public float Speed;
    //弾
    public GameObject Bullet;

    // Update is called once per frame
    void Update()
    {
        //X軸に移動
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        //X軸に移動
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        
        //エリアを指定して移動する
        transform.position = new Vector3(
            
            //X軸に移動可能エリア指定
            Mathf.Clamp (transform.position.x + moveX, -15.0f,15.0f),
            //X軸に移動可能エリア指定
            Mathf.Clamp (transform.position.y + moveY, 0.0f, 4.5f)
        );
        
        //マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            //弾を製成

            //Instantiate(クローン生成するもの.gameObject, クローンを作成する場所, クローンの向き);
            Instantiate(Bullet.gameObject,this.transform.position,Quaternion.identity);

            //マウスクリックで攻撃モーション
            //animator.SetTrigger("Attack");    
        }
    }
}
