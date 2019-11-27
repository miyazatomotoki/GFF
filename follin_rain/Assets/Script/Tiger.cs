using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    public float speed = 1.0f;
    public float upPosition;
    public float downPosition;
    bool move = false;
    void Update()
    {
        switch (move)
        {
            case true:
                //毎フレームｘポジションを少しづつ移動移動させる
                transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
                break;
            case false:
                //毎フレームｘポジションを少しづつ移動移動させる
                transform.Translate(1 * speed * Time.deltaTime, 0, 0);
                break;
        }
        //スクロールが目標ポイントまで到着したかをチェック
        if (Mathf.Ceil(transform.position.x) == downPosition) move = false;
        if (Mathf.Ceil(transform.position.x) == upPosition) move = true;
    }
}
