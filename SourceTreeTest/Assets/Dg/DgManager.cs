using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DgManager : MonoBehaviour
{
    [SerializeField]private GameObject apple;
    // Start is called before the first frame update
    void Start()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(apple.transform.DOMove(new Vector3(5, 5, 5), 4f));
        seq.Join(apple.transform.DORotate(new Vector3(0, 0, 180), 4f));
        seq.Join(apple.transform.DOScale(5f,4f));
        seq.AppendInterval(3.0f);
        seq.Append(apple.transform.DOMove(new Vector3(0, 0, 0), 4f));
        seq.Join(apple.transform.DORotate(new Vector3(0, 0, 0), 4f));
        seq.Join(apple.transform.DOScale(1f, 4f));
        seq.Play();
    }
    //Sequence seq = DOTween.Sequence();
    //seq.Append(animation);  // animation 바로 실행  
    //seq.Append(animation2); // animation 완료 후 animation2를 실행
    //seq.AppendInterval(1.0f); // 1초를 기다림
    //seq.AppendCallback(myCallback); // animation2 완료 후 1초를 기다렸다 myCallbak 호출
    //seq.Join(animation3); // animation과 동시에 실행
    //seq.Prepend(animation4); // 맨 처음에 실행
    //seq.Insert(1.0f, animation5); // 1초 후 animation5 실행
    //seq.InsertCallback(1.0f, myCallback); // 1초후 myCallback 호출
 
    // 람다식 콜백 적용
    //seq.InsertCallback(1.0f, () => { Debug.Log("1초 후 실행" });

    //seq.Play(); // Sequence 실행 
    //Colored

}
