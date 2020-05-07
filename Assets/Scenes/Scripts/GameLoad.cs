using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class GameLoad : MonoBehaviour
{
    [SerializeField] float startThrow;
    void GameStart() {
        startThrow = CrossPlatformInputManager.GetAxis("Submit");
        if (startThrow > 0) {
            LoadFirstScene();
        }
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    void Update() {
        GameStart();
    }
}
