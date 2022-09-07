using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEEND_Button : MonoBehaviour
{
    //メソッドの定義
    public void TheEnd_button()
    {
        #if UNITY_EDITOR
            //ゲームプレイ終了
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            //ゲームプレイ終了
            Application.Quit();
        #endif

    }
}
