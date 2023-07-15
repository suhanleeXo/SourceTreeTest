using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] Enemy = new GameObject[1];
    [SerializeField] private float genTime;
    // Start is called before the first frame updates
    void Start()
    {
        genTime = 10f;
        StartCoroutine(EnemyCreate(genTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemyCreate(float timer)
    {
        int enemyType = Random.Range(0, Enemy.Length);
        yield return new WaitForSeconds(timer);
        GameObject go = Instantiate(Enemy[enemyType]);
        StartCoroutine(EnemyCreate(genTime));
    }
}
