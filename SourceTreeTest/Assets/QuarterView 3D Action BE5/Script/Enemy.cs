using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator anim;
    public float dmg = 1f;
    [SerializeField] private float maxHP;
    [SerializeField] private float curHP;
    [SerializeField] private float moveSpeed;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        player = GameObject.FindWithTag("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.transform.position- this.transform.position;


        // Ÿ�� �������� ȸ����
        transform.LookAt(player.transform);

        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.CompareTag("playerAttack"))
        {
            //������ �ޱ�
        }
        else if(collision.collider.CompareTag("Player"))
        {
            anim.SetTrigger("isAttack");
        }
    }

}
