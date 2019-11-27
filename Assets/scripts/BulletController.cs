using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public float Bullettime;
    public int damagetg;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Bullettime -= Time.deltaTime;
        if(Bullettime<=0)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            other.gameObject.GetComponent<Enemyhealth>().Hurtenemy(damagetg);
            Destroy(gameObject);
        }
    }
}
