using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, -0.04f, 0);
        if (this.transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
        Vector3 p1 = this.transform.position;
        Vector3 p2 = Player.transform.position;
        float r1=0.5f;
        float r2 = 1.0f;
        Vector3 dir = p1 - p2;
        float d = dir.magnitude;
        if (d < r1 + r2)
        {
            GameObject GameDirector = GameObject.Find("GameDirector");
            GameDirector.GetComponent<GameDirector_4>().DescreaseHP();
            Destroy(gameObject);
        }

    }

    

}
