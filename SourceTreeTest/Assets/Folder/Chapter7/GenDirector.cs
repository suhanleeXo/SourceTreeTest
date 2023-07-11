using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GenDirector : MonoBehaviour
{
    [SerializeField] private GameObject ball_prefab;
    [SerializeField] private Transform initPos;
    [SerializeField] Vector3 mousepos;
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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                mousepos= hit.point;
                Debug.Log(mousepos);
            }
            GameObject go = Instantiate(ball_prefab, initPos);
            
            Shoot(go, mousepos);
        }
    }
    public void Shoot(GameObject go, Vector3 dir)
    {
        go.GetComponent<Rigidbody>().AddForce(dir*10);
    }
}
