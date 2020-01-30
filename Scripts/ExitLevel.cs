using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    int currentScene;
    MovePlayer moveplayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadExitLevel());
    }


    private void Start()
    {
        moveplayer = FindObjectOfType<MovePlayer>();
        SceneManager.GetSceneByBuildIndex(currentScene);
    }


    IEnumerator LoadExitLevel()
    {
        moveplayer.isAlive = false;
        moveplayer.LoadExitAnimation();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(currentScene + 1);
        

    }









}
