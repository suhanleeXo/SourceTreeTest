using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cat : MonoBehaviour
{
    Rigidbody2D rigid;
    float jumpForce = 680f;
    float maxSpeed = 2.0f;
    float walkForce = 30f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int isRight = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid.AddForce(transform.up * this.jumpForce);
          
        }
            
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isRight = 1;
            this.transform.localScale=new Vector3(1,1,1);
        }
            
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isRight = -1;
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
            
        float speed = Mathf.Abs(this.rigid.velocity.x);
        if (speed < this.maxSpeed)
            this.rigid.AddForce(transform.right * isRight * walkForce);
        this.anim.speed = speed / 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("clear");
    }
}
