using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimController : MonoBehaviour
{
    //変数 targetPosを宣言（座標）
    public Vector3 targetPos;
    //照準器の画像設定
    public Image aimImage;
    

    // Update is called once per frame
    void Update()
    {
        //「マウスの位置」と「照準器の位置」を同期させる。
        transform.position = Input.mousePosition;
        //RaycastHit型の変数に接触
        RaycastHit hit;
        //MainCameraからマウスの位置にRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Rayを投射し、もし何らかのオブジェクトと衝突したら
        if(Physics.Raycast(ray, out hit))
        {
            // Ray（光線）がColliderと衝突した地点の座標を取得
            targetPos = hit.point;
            //座標出力
            print(targetPos);

            //もしタグ名「Enemy」に衝突したら
            if(hit.transform.CompareTag("Enemy"))
            {
                //照準器を赤色に変化させる
                aimImage.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }
            else
            {
                //照準器の色は白になる
                aimImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }

        else
        {
            //照準器の色は白になる
            aimImage.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}
