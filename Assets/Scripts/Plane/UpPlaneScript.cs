using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPlaneScript : MonoBehaviour
{
    public GameObject Plane;

    GameObject[] step = new GameObject[100];

    // Planeの移動速度
    float speed = 10;
    // Planeの移動制限
    float disapper = -10;
    // 再生成位置
    float respown = 40;

    int fase = 1;

    /// <summary>
    /// 開始処理
    /// </summary>
    private void Start()
    {
        for(int i = 0; i < step.Length;i++)
        {
            // x軸4の倍数ごとにPlane出現
            step[i] = Instantiate(Plane, new Vector3(i, 4, 0), Quaternion.identity);
        }
    }
    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            fase = 2;
                         
        }
        // すべてのPlane
        for (int i = 0; i < step.Length; i++)
        {
        　　// 1秒あたりx軸方向にspeed分移動
            step[i].gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            // x座標がdisapierより小さくなったら
            if(step[i].gameObject.transform.position.x < disapper)
            {
                ChangeScale(i);
                // 再生成
                step[i].gameObject.transform.position = new Vector3(respown, 4, 0);
            }
        }

    }

    /// <summary>
    /// フィールドの大きさ変更
    /// </summary>
    void ChangeScale(int i)
    {
        int x = (i + 9) % 10;

        // 高さが負にならないように
        if(step[x].transform.localScale.y == 0.5)
        {
            step[i].transform.localScale = 
                step[x].transform.localScale + new Vector3(0, Random.Range(0, 2), 0);
        }
        else
        {
            step[i].transform.localScale =
                step[x].transform.localScale + new Vector3(0, Random.Range(-1, 2), 0);


        }
    }
}
