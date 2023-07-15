using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerSphere : MonoBehaviour
{
    Rigidbody rigid;
    float speed = 5f;
    float jumpPower = 10f;
    [SerializeField] private Text gametext;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        StartCoroutine("MousePositionLog");
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

        Vector3 inputDir = new Vector3(h, 0, v) * Time.deltaTime;
        transform.Translate(inputDir * speed);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            transform.position = new Vector3(4.5f,30.5f,0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Flag"))
        {
            gametext.text = "Congratulation!!!!\nGame Clear!!!";
        }
    }
    IEnumerator MousePositionLog()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log(Input.mousePosition);
        StartCoroutine("MousePositionLog");
    }
}
