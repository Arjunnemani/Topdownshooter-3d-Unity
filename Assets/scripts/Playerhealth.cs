using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public int startH;
    public int currentH;
    public float flashH;
    private float flashC;
    private Renderer rend;
    private Color storeC;
    void Start()
    {
        currentH = startH;
        rend = GetComponent<Renderer>();
        storeC = rend.material.GetColor("_Color");
    }

   
    void Update()
    {
        if(currentH<=0)
        {
            gameObject.SetActive(false);
        }
        if(flashC<=0)
        {
            rend.material.SetColor("_Color", storeC);
        }
    }
    public void Playerhurt(int damageA)
    {
        currentH -= damageA;
        flashC = flashH;
        rend.material.SetColor("_Color", Color.white);
    }
}
