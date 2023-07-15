using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSuhan : MonoBehaviour
{
    Animator anim;
    Rigidbody rigid;
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float JumpSpeed = 10f;
    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private float MaxHP;
    [SerializeField] private float CurHP;
    [SerializeField] private float Dmg;
    bool isJump;
    void Start()
    {
        Init();
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }
    
    void Init()
    {
        MoveSpeed = 10f;
        MaxHP = 100f;
        CurHP = 100f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();      
        Jump();
    }
    

    void Move()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(h, 0, v);
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed = 20f;
            anim.SetTrigger("isRun");
        }
        else if((h!=0 | v!=0)&!isJump)
        {
            MoveSpeed = 10f;
            anim.SetTrigger("isWalk");
        }
        else if((h==0 & h==0) & !isJump)
        {
            anim.SetTrigger("isIdle");
        }
        transform.Translate(moveDir * MoveSpeed * Time.deltaTime);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), Time.deltaTime * rotateSpeed);
        
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&!isJump)
        {
            anim.SetTrigger("isJump");
            isJump = true;
            rigid.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
        }    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            anim.SetTrigger("isIdle");
            isJump = false;
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            CurHP -= collision.gameObject.GetComponent<Enemy>().dmg;
        }
    }
}
