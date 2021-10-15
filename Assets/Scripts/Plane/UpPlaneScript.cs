using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPlaneScript : MonoBehaviour
{
    public GameObject Plane;

    GameObject[] step = new GameObject[100];

    // Plane�̈ړ����x
    float speed = 10;
    // Plane�̈ړ�����
    float disapper = -10;
    // �Đ����ʒu
    float respown = 40;

    int fase = 1;

    /// <summary>
    /// �J�n����
    /// </summary>
    private void Start()
    {
        for(int i = 0; i < step.Length;i++)
        {
            // x��4�̔{�����Ƃ�Plane�o��
            step[i] = Instantiate(Plane, new Vector3(i, 4, 0), Quaternion.identity);
        }
    }
    /// <summary>
    /// �X�V����
    /// </summary>
    private void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            fase = 2;
                         
        }
        // ���ׂĂ�Plane
        for (int i = 0; i < step.Length; i++)
        {
        �@�@// 1�b������x��������speed���ړ�
            step[i].gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            // x���W��disapier��菬�����Ȃ�����
            if(step[i].gameObject.transform.position.x < disapper)
            {
                ChangeScale(i);
                // �Đ���
                step[i].gameObject.transform.position = new Vector3(respown, 4, 0);
            }
        }

    }

    /// <summary>
    /// �t�B�[���h�̑傫���ύX
    /// </summary>
    void ChangeScale(int i)
    {
        int x = (i + 9) % 10;

        // ���������ɂȂ�Ȃ��悤��
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
