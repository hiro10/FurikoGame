using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    //円運動の中心となるGameObject
    public GameObject center;
    //円運動の速度
    float speed = 20;
    Rigidbody rigidbody;
    RaycastHit hit;


    /// <summary>
    /// 開始処理
    /// </summary>
    private void Start()
    {
        // rigidbodyの取得
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(gameObject.transform.position, Vector3.up * 6, Color.blue, 0.1f);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.useGravity = false;
            if (Physics.Raycast(gameObject.transform.position, Vector3.up, out hit, 60.0f))
            {
                //center.transform.position = hit.point;              
                Debug.Log(hit.point);
                //center.transform.position = hit.collider.gameObject.transform.position;
               // Debug.Log(center.transform.position);
            }
           // transform.RotateAround(hit.point,
           //transform.forward, speed * Time.deltaTime);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            //center = null;
            rigidbody.useGravity = true;
        }

        if (rigidbody.useGravity == false)
        {
            transform.RotateAround(hit.point,
               transform.forward, speed * Time.deltaTime);
        }
        //if (center != null)
        //{
        //    //RotateAround(円運動の中心,進行方向,速度)
        //    transform.RotateAround(center.transform.position,
        //    transform.forward, speed * Time.deltaTime);
        //}
    }

    //void RayTest()
    //{
    //    //Rayの作成　　　　　　　↓Rayを飛ばす原点　　　↓Rayを飛ばす方向
    //    Ray ray = new Ray(transform.position, new Vector3(0, 10, 0));

    //    //Rayが当たったオブジェクトの情報を入れる箱
    //    RaycastHit hit;

    //    //Rayの飛ばせる距離
    //    int distance = 10;

    //    //Rayの可視化    ↓Rayの原点　　　　↓Rayの方向　　　　　　　　　↓Rayの色
    //    Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);

    //    //もしRayにオブジェクトが衝突したら
    //    //                  ↓Ray  ↓Rayが当たったオブジェクト ↓距離
    //    if (Physics.Raycast(ray, out hit, distance))
    //    {
    //        hit.transform.position
    //    }
    //}
}
