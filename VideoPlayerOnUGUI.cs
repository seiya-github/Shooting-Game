using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;



[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]

public class VideoPlayerOnUGUI : MonoBehaviour {
    //画像
    RawImage image;
    //ビデオ
    VideoPlayer player;
    
    //メソッドの定義（AwakeはStartメソッドの前およびプレハブのインスタンス化直後）
    void Awake() {
        //「RawImage」コンポーネントを取得
        image = GetComponent<RawImage>();
        //「VideoPlayer」コンポーネントを取得
        player = GetComponent<VideoPlayer>();
        //「AudioSource」コンポーネントを取得
        var source = GetComponent<AudioSource>();
        
        player.EnableAudioTrack(0, true);
        //Audio Sourceにあらかじめビデオに追加したsource
        player.SetTargetAudioSource(0, source);
    }
    
    // Update is called once per frame
    void Update() {
        //もしビデオの再生の準備に成功したら
        if (player.isPrepared) {
            //画像テクスチャにビデオテクスチャを代入する
            image.texture = player.texture;
        }
    }
}
