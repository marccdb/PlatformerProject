using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{

    int startingSceneIndex;

    private void Awake()
    {
        if(FindObjectsOfType<ScenePersist>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }




    void Start()
    { 
        startingSceneIndex = SceneManager.GetActiveScene().buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene != startingSceneIndex)
        {
            Destroy(gameObject);
        }
    }
}
