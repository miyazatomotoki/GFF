using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaCamera : MonoBehaviour
{
    public GameObject player;
    public int zahyou;
    public float X_zahyou;
    private Vector3 preyer_pozi;
    public float X_Min, X_Max, Y_Min, Y_Max;
    // Use this for initialization
   
    // Update is called once per frame
    void Update()
    {
        preyer_pozi = player.transform.position;
       
        preyer_pozi.x = Mathf.Clamp(preyer_pozi.x, X_Min, X_Max); //x位置が常に範囲内か監視
        preyer_pozi.y = Mathf.Clamp(preyer_pozi.y, Y_Min, Y_Max); //x位置が常に範囲内か監視
        transform.position = new Vector3(preyer_pozi.x + X_zahyou, preyer_pozi.y, zahyou);
        
    }

} 

