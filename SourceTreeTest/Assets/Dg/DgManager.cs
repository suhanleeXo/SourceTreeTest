using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DgManager : MonoBehaviour
{
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        Vector3 targetPos = new Vector3(3f, 3f, 3f);
        cube.transform.DOMove(targetPos, 5f);
        cube.transform.DORotate(new Vector3(0, 360, 0), 5f);
        cube.transform.DOShakeRotation(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
