using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    //敵
    public GameObject enemyPrefab;
    //敵生成時間間隔の最小の値
    public float minTime = 2f;
    //敵生成時間間隔の最大の値
    public float maxTime = 5f;
    //X座標の最小値
    public float xMinPosition = -10f;
    //X座標の最大値
    public float xMaxPosition = 10f;
    //Y座標の最小値
    public float yMinPosition = 0f;
    //Y座標の最大値
    public float yMaxPosition = 10f;
    //Z座標の最小値
    public float zMinPosition = 10f;
    //Z座標の最大値
    public float zMaxPosition = 20f;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //敵生成時間間隔を決定する
        interval = GetRandomTime();    
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;
        
        //経過時間が生成時間になったとき（生成時間より大きくなったとき）
        if(time > interval)
        {
            //Enemyをインスタンス化する（生成する）
            GameObject enemy = Instantiate(enemyPrefab);
            //生成場所ランダム
            enemy.transform.position = GetRandomPosition();
            //
            time = 0f;
            //時間間隔ランダム
            interval = GetRandomTime();
        }

    }

    //時間間隔ランダムメソッド
    private float GetRandomTime()
    {
        //最大から最小までの時間をランダムに返す
        return Random.Range(minTime,maxTime);
    }

    //生成場所ランダムメソッド
    private Vector3 GetRandomPosition()
    {
        //最大から最小までの座標をランダムに格納する
        float x =Random.Range(xMinPosition,xMaxPosition);
        float y =Random.Range(yMinPosition,yMaxPosition);
        float z =Random.Range(zMinPosition,zMaxPosition);

        //Vector3型のPositionを返す（座標を返す）
        return new Vector3(x,y,z);
    }
}
