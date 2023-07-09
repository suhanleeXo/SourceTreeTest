using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public float speed;
    public Vector3 startPos;
    public Vector3 endPos;
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            float SwipeLength = endPos.x - startPos.x;
            Debug.Log(SwipeLength);
            this.speed = SwipeLength / 500.0f;
            this.GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);
        speed *= 0.96f;
    }
}
