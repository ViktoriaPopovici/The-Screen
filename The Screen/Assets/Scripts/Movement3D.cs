using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    private Vector3 target;
    private float speed = 1.0f;

    void Update()
    {
        //makes boxes move towards a certain point in the game (i.e. middle of the pit)
        float step = speed * Time.deltaTime; // calculate distance to move
        target = new Vector3(0, -1.1f, -1.25f);
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
