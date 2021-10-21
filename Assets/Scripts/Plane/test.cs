using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    //‰~‰^“®‚Ì’†S‚Æ‚È‚éGameObject
    public GameObject center;
    //‰~‰^“®‚Ì‘¬“x
    float speed = 20;
    Rigidbody rigidbody;
    RaycastHit hit;


    /// <summary>
    /// ŠJnˆ—
    /// </summary>
    private void Start()
    {
        // rigidbody‚Ìæ“¾
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
    }

    // Update is called once per frame
    /// <summary>
    /// Ray‚ª“–‚½‚Á‚½êŠ‚ğ‰~‰^“®‚Ì’†S‚Æ‚Æ‚ç‚¦‚Ä‚¢‚éi‚Å‚à‚¤‚Ü‚­‚¢‚©‚È‚¢j
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
