using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    //体力ゲージ
    public int playerHP;
    //体力
    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        //最大体力
        hpSlider.maxValue = playerHP;

        //体力
        hpSlider.value = playerHP;
    }

    //メソッドの定義（物体がすり抜けた時）
    private void OnTriggerEnter(Collider other)
    {
        //もしタグ名「Enemy_Bullet」のGameObjectに衝突したら
        if(other.gameObject.CompareTag("Enemy_Bullet"))
        {
            //体力が１減る
            playerHP -= 1;
            //体力ゲージが減る
            hpSlider.value = playerHP;

            //もし体力ゲージが０になったら
            if(playerHP == 0)
            {
                //「Score Result Screen」に遷移する。
                SceneManager.LoadScene("Score Result Screen");
            }
        }
    }
}
