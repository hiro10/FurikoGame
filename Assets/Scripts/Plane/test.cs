using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    //�~�^���̒��S�ƂȂ�GameObject
    public GameObject center;
    //�~�^���̑��x
    float speed = 20;
    Rigidbody rigidbody;
    RaycastHit hit;


    /// <summary>
    /// �J�n����
    /// </summary>
    private void Start()
    {
        // rigidbody�̎擾
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
        //    //RotateAround(�~�^���̒��S,�i�s����,���x)
        //    transform.RotateAround(center.transform.position,
        //    transform.forward, speed * Time.deltaTime);
        //}
    }

    //void RayTest()
    //{
    //    //Ray�̍쐬�@�@�@�@�@�@�@��Ray���΂����_�@�@�@��Ray���΂�����
    //    Ray ray = new Ray(transform.position, new Vector3(0, 10, 0));

    //    //Ray�����������I�u�W�F�N�g�̏������锠
    //    RaycastHit hit;

    //    //Ray�̔�΂��鋗��
    //    int distance = 10;

    //    //Ray�̉���    ��Ray�̌��_�@�@�@�@��Ray�̕����@�@�@�@�@�@�@�@�@��Ray�̐F
    //    Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);

    //    //����Ray�ɃI�u�W�F�N�g���Փ˂�����
    //    //                  ��Ray  ��Ray�����������I�u�W�F�N�g ������
    //    if (Physics.Raycast(ray, out hit, distance))
    //    {
    //        hit.transform.position
    //    }
    //}
}
