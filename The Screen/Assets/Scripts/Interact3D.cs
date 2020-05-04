using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact3D : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 playerPos = new Vector3(0, -1.359f, -0.779f);
    private Vector3 mousePosition;
   //public GameObject sphere;
    private float Zcoord;
    private double range = 2.5;


   /* private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            sphere.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
    }*/

    //joint is put on the boxes
    //the connected body is the sphere
    private void OnMouseDown()
    {
        Zcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseAsWorldPoint();

        /*if (Vector3.Distance(playerPos, GetMouseAsWorldPoint()) < range)
        {
            FixedJoint myJoint = (FixedJoint)gameObject.AddComponent<FixedJoint>();
            myJoint.connectedBody = sphere.GetComponent<Rigidbody>();
        }*/
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Zcoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        if (Vector3.Distance(playerPos, GetMouseAsWorldPoint()) < range)
        {
            transform.position = GetMouseAsWorldPoint() + offset;
        }
    }
}
