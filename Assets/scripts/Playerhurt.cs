using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhurt : MonoBehaviour
{
    public int damageTG;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<Playerhealth>().Playerhurt(damageTG);
        }
    }

}
