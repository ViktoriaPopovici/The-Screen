using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame3D : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        SceneManager.LoadScene("StroopRoom");
    }
}
