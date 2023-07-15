using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 cubePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DragAndDrop2()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction,Color.green);
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction*1000f, Color.green);
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit))
        {
            if (Input.GetMouseButton(0))
            {
                transform.Translate(new Vector3(hit.point.x, 0.5f,hit.point.z));
                Debug.Log(hit.point);
            }
        }
    }
}
