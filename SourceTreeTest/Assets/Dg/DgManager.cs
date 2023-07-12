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
    //seq.Append(animation);  // animation �ٷ� ����  
    //seq.Append(animation2); // animation �Ϸ� �� animation2�� ����
    //seq.AppendInterval(1.0f); // 1�ʸ� ��ٸ�
    //seq.AppendCallback(myCallback); // animation2 �Ϸ� �� 1�ʸ� ��ٷȴ� myCallbak ȣ��
    //seq.Join(animation3); // animation�� ���ÿ� ����
    //seq.Prepend(animation4); // �� ó���� ����
    //seq.Insert(1.0f, animation5); // 1�� �� animation5 ����
    //seq.InsertCallback(1.0f, myCallback); // 1���� myCallback ȣ��
 
    // ���ٽ� �ݹ� ����
    //seq.InsertCallback(1.0f, () => { Debug.Log("1�� �� ����" });

    //seq.Play(); // Sequence ���� 
    //Colored

}
