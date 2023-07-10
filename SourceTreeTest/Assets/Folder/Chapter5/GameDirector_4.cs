using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector_4 : MonoBehaviour
{
    GameObject hpGuage;
    // Start is called before the first frame update
    void Start()
    {
        hpGuage = GameObject.Find("HPGuage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DescreaseHP()
    {
        hpGuage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
