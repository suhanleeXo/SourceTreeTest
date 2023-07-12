using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GenDirector : MonoBehaviour
{
    public GameObject ball_prefab;
    [SerializeField] Text score;
    public int scoreNum;
    public static GenDirector instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Á¡¼ö : "+scoreNum.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(ball_prefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Debug.Log(worldDir);
            go.GetComponent<ball>().Shoot(worldDir.normalized*2000);
        }
    }
}
   
