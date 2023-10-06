using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorMenu : MonoBehaviour
{
    public void Level01()
    {
        SceneManager.LoadScene(2);
    }

    public void Level02()
    {
        SceneManager.LoadScene(3);
    }

    public void Level03()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}