using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float generateTime = 2f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > generateTime)
        {
            timer = 0f;
            GameObject go = Instantiate(arrowPrefab);
            int xPos = Random.Range(-6, 6);
            go.transform.position = new Vector3(xPos, 7, 0);
        }
    }
}
