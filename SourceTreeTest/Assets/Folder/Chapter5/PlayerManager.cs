using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Translate(-1f, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Translate(1f, 0, 0);
        }
          
        
    }
    public void RightMove()
    {
        this.transform.Translate(1f, 0, 0);
    }
    public void LeftMove()
    {
        this.transform.Translate(-1f, 0, 0);
    }
}
