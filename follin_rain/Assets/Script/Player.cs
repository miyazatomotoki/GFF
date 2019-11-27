using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Joystick joystick = null;
    public float speed; //歩くスピード
    private new Rigidbody2D rigidbody2D;
    public float jumpPower; //ジャンプ力
    bool jump = true;//ジャンプ用
    bool Tuta = false;


    //private Animator anim;
    void Start()
    {
        //各コンポーネントをキャッシュしておく
        //anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    void Update()
    {
        Vector3 player_pos = transform.position;

        player_pos.x = Mathf.Clamp(player_pos.x, 0.19f, 55.5f);
        player_pos.y = Mathf.Clamp(player_pos.y, -10f, 5);//x位置が常に範囲内か監視
        transform.position = new Vector3(player_pos.x, player_pos.y);
        if (Input.GetKeyDown("space"))
        {
            //着地していた時、
            if (jump)
            {
                //Dashアニメーションを止めて、Jumpアニメーションを実行
                //anim.SetBool("Dash", false);
                //anim.SetTrigger("Jump");
                //着地判定をfalse
                jump = false;
                //AddForceにて上方向へ力を加える
                rigidbody2D.AddForce(Vector2.up * jumpPower);
            }
        }
        //上下への移動速度を取得
        float velY = rigidbody2D.velocity.y;
        //移動速度が0.1より大きければ上昇
        bool isJumping = velY > 0.1f ? true : false;
        //移動速度が-0.1より小さければ下降
        bool isFalling = velY < -0.1f ? true : false;
        //結果をアニメータービューの変数へ反映する
        //anim.SetBool("isJumping", isJumping);
        //anim.SetBool("isFalling", isFalling);
    }
    void FixedUpdate()
    {


        //左キー: -1、右キー: 1
        float x = Input.GetAxisRaw("Horizontal");
        float joyX = joystick.Horizontal;
        float joyY = joystick.Vertical;
        //float vertical = joystick.Vertical;

        //左か右を入力したら
        if (x != 0 || joyX != 0)
        {
            //入力方向へ移動
            //rigidbody2D.velocity = new Vector2(x * speed, rigidbody2D.velocity.y);

            if (Tuta)
            {
                rigidbody2D.velocity = new Vector2(joyX * speed, joyY * speed);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(joyX * speed, rigidbody2D.velocity.y);
            }


            //Debug.Log(joyX);
            //localScale.xを-1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = x;
            transform.localScale = temp;
            if (joyX <= 0.000000001f)
            {
                joyX = -1;
            }
            else
            {
                joyX = 1;
            }
            Vector2 foem = transform.localScale;
            foem.x = joyX;
            transform.localScale = foem;
            //Wait→Dash
            //anim.SetBool("Dash", true);
            //左も右も入力していなかったら
        }
        else
        {
            //横移動の速度を0にしてピタッと止まるようにする
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            //Dash→Wait
            //anim.SetBool("Dash", false);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "jimen" || !Tuta)
        {
            jump = true;//ジャンプon
            //Debug.Log(jump);
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "tuta")
        {
            Tuta = true;
            // Debug.Log("a");
            /*idou = false;//ツタに重なってれば、ツタの挙動をする
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
            float joyX = joystick.Horizontal;
            float joyY = joystick.Vertical;
           Debug.Log(joyY);
           rigidbody2D.velocity = new Vector2(joyX * speed, rigidbody2D.velocity.y);*/
        }
    }
    public void Jump()
    {
        if (jump)
        {
            //Dashアニメーションを止めて、Jumpアニメーションを実行
            //anim.SetBool("Dash", false);
            //anim.SetTrigger("Jump");
            //着地判定をfalse
            jump = false;
            //AddForceにて上方向へ力を加える
            rigidbody2D.AddForce(Vector2.up * jumpPower);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "tuta")
        {
            Tuta = false;
        }
    }
}