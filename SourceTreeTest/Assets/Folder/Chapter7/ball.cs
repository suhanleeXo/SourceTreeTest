using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ParticleSystem particle;
    Rigidbody rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        particle=GetComponent<ParticleSystem>();
        //Shoot(new Vector3(0, 200, 2000));
    }

    private void OnCollisionEnter(Collision collision)
    {
        rigid.isKinematic = true;
        particle.Play();
        GenDirector.instance.scoreNum += 10;
        StartCoroutine(Destory_Ball());
    }

    IEnumerator Destory_Ball()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
