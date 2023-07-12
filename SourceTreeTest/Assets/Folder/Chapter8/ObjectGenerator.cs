using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] private GameObject apple_Prefab;
    [SerializeField] private GameObject bomb_Prefab;
    Transform initPos;
    void Start()
    {
        StartCoroutine(GenStart());
    }

    IEnumerator GenStart()
    {
        int rand = Random.Range(0, 2);
        int xPos = Random.Range(-1, 2);
        int zPos = Random.Range(-1, 2);
        
        yield return new WaitForSeconds(2.0f);
        if(rand==0)
        {
            GameObject go=Instantiate(apple_Prefab);
            go.transform.position = new Vector3(xPos, 5, zPos);
            
        }
        else
        {
            GameObject go = Instantiate(bomb_Prefab);
            go.transform.position = new Vector3(xPos, 5, zPos);
        }
        StartCoroutine(GenStart());
    }
}
