using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    [SerializeField] float RotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.RotateSpeed = 100;
        }
        transform.Rotate(0, 0, this.RotateSpeed);
        this.RotateSpeed *= 0.96f;
        
    }
}
