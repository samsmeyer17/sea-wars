using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadFirstScene", 2f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
