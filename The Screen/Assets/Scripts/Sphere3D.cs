using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere3D : MonoBehaviour
{
    private Vector3 offset;
    private float Zcoord;
    private Vector3 playerPos = new Vector3(0, -1.359f, -0.779f);
    private double range = 2.5;
    private Vector3 mousePosition;
    public GameObject sphere;
    public float moveSpeed = 0.1f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            sphere.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
    }
    
}
