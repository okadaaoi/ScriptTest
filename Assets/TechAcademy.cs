/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;   //魔力


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.mp + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りmpを減らす
        this.mp -= damage;
    }
}
public class TechAcademy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素数５の配列を初期化する
        /*int[] points = new int[5];

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
}*/