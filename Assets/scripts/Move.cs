using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public float speed;
    private Rigidbody myRigidbody;


    public shooting gun;
    
    private Camera MC;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        MC = FindObjectOfType<Camera>();
    }

    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical")*Time.deltaTime);
        Ray cameraRay = MC.ScreenPointToRay(Input.mousePosition);
        Plane grounP = new Plane(Vector3.up, Vector3.zero);
        float rayLength;
        if(grounP.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointTL = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointTL, Color.blue);
            transform.LookAt(new Vector3(pointTL.x, transform.position.y,pointTL.z));
        }
        if (Input.GetMouseButtonDown(0))
            gun.isFiring = true;
        if (Input.GetMouseButtonUp(0))
            gun.isFiring = false;
    }
    
    
    
}
