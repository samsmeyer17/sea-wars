using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok as long as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In Seconds")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

    Rigidbody rigidbody;
    AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadCurrentLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    } 

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("LoadCurrentLevel", levelLoadDelay); // string referenced
    }
}
