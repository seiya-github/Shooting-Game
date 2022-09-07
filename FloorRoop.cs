using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FloorRoop : MonoBehaviour
{
    //床の移動速度
    private float speed = 50;
   
   //Update is called once per frame
   void Update()
   {
        //通過した床の削除
        transform.position -= new Vector3(0, 0, Time.deltaTime * speed);
        
        //もしZ軸500を通過したら
        if(transform.position.z <= -500f){
            
            //Y軸-20,Z軸2500に床を生成する
            transform.position = new Vector3(0, -20, 2500);

        }
    }
}