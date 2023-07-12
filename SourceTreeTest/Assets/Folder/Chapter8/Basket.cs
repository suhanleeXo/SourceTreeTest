using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    public GameDirector_chapter7 manager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Vector3 transPos = new Vector3(hit.point.x, 0, hit.point.z);
                this.transform.position=transPos;
            }
            

            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Apple"))
        {
            manager.SetScore(10);
        }
        else if(collision.collider.CompareTag("Bomb"))
        {
            manager.SetScore(-10);
        }
    }
}
