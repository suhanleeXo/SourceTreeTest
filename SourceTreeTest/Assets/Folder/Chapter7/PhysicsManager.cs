using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhysicsManager : MonoBehaviour
{
    [SerializeField]GameObject circle;
    float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            circle.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            circle.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            circle.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            circle.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
        }
    }
    public void OnClick_LeftMove()
    {
        circle.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
    }
    
    public void OnClick_RightMove()
    {
        circle.transform.Translate(new Vector3(1, 0, 0)*Time.deltaTime*speed);
    }

    public void OnClick_DownMove()
    {
        circle.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
    }
    public void OnClick_UpMove()
    {
        circle.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
