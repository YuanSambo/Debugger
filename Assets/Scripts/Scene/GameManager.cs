using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{



    public void ChangeBattleScene()
    {
        SceneManager.LoadScene("Battle");

    }

    public void ChangeMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }


    public void Stage2()
    {
        SceneManager.LoadScene("Battle2");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }


}

