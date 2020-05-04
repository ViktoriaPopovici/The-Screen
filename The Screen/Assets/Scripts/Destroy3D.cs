using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy3D : MonoBehaviour
{
    public static int score;
    private int temp;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);

    }
    //When the "Box" GameObjects collide with the "Pit" they get deactivated 
    //their position is also set to 0,0,0 as to not restrict the ability to pick up incoming boxes
    void OnCollisionEnter(Collision collision)
    {
        collision.collider.gameObject.SetActive(false);
        collision.collider.gameObject.transform.localPosition = Vector3.zero;
        temp++;
        PlayerPrefs.SetInt("Score", score + temp);
        PlayerPrefs.Save();
    }
}
