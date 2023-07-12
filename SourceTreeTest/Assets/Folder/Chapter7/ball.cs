using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ParticleSystem particle;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        particle=GetComponent<ParticleSystem>();
        //Shoot(new Vector3(0, 200, 2000));
    }
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        particle.Play();
        GenDirector.instance.scoreNum += 10;
        //StartCoroutine(Destory_Ball());
    }

    IEnumerator Destory_Ball()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
