using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphere : MonoBehaviour
{
    Rigidbody rigid;
    float speed = 5f;
    float jumpPower = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir *= speed * Time.deltaTime;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {

        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {

        }
    }
}
