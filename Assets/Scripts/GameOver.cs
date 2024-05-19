using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool gameover;
    public GameObject gameOverPanel;
    void Start()
    {
        gameover = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
