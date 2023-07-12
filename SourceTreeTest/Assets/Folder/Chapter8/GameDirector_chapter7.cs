using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector_chapter7 : MonoBehaviour
{
    [SerializeField] private Text scoretext;
    [SerializeField] private Text Timertext;
    int score=0;
    int timer = 30;
    
    void Start()
    {
        StartCoroutine(Timer());
    }
    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Á¡¼ö : "+ score.ToString();
        Timertext.text = "Timer : " + timer.ToString();
    }


    public int GetScore()
    {
        return score;
    }
    public void SetScore(int num)
    {
        score += num;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        timer--;
        StartCoroutine(Timer());
    }
}
