using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPos = cat.transform.position;
        transform.position = new Vector3(catPos.x,catPos.y,transform.position.z);
    }

}
