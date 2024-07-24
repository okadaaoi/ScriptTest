using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //private int hp = 100;   //体力
    //private int power = 25; //攻撃力
    private int mp = 53;    //魔力量

    int Add(int mp, int b)
    {
        //第一引数と第二引数の値を足した値を返す関数
        int c = mp - b;
        //変数c呼び出しm元の関数に返す
        return c;
    }
    // 攻撃用の関数
    /*public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }*/

    // 防御用の関数
    /*public void Defence(int damage)
    {
        /*Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }*/
    public void Magic()
    {
        //Add関数に53と５の引数を渡し、返り値をnum変数に代入する
        int num = Add(53, 6);
        //numを表示する
        Debug.Log("魔法攻撃をした。残りMPは" + num);
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        //lastboss.Attack();

        // 防御用の関数を呼び出す
        //lastboss.Defence(3);

        //魔法用の関数を呼び出す
        lastboss.Magic();

        //要素数５の配列を初期化する
        int[] points = new int[5];

        //配列の各要素に値を代入する
        points[0] = 1;
        points[1] = 2;
        points[2] = 3;
        points[3] = 4;
        points[4] = 5;

        //配列の要素を全て表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
        //逆順
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}