using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadSceneAsync("Level");
    }
    public void exitGame()
    {
        Application.Quit();
        EditorApplication.ExitPlaymode();
        Debug.Log("The Game is Closed");
    }

    public void ReloadScene()
    {
        gameObject.SetActive(true);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
