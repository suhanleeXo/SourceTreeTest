using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{

    [SerializeField] private Text colorText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if((Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)))
            {
                
                if (hit.collider.name=="RedCube")
                {
                    colorText.text = "this cube is Red Cube!!";
                }
                else if (hit.collider.name == "GreenCube")
                {
                    colorText.text = "this cube is Green Cube!!";
                }
                else if (hit.collider.name == "BlueCube")
                {
                    colorText.text = "this cube is Blue Cube!!";
                }
            }
            
        }
    }
}
