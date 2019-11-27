using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public int health;
    private int Currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        Currenthealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(Currenthealth<=0)
        {
            Destroy(gameObject);

        }
    }
public void Hurtenemy(int damage)
    {
        Currenthealth -= damage;
    }
}
