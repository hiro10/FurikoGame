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
    /// <summary>
    /// Rayが当たった場所を円運動の中心ととらえている（でもうまくいかない）
    /// </summary>
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
    }
}
