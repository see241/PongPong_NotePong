using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{

    public void RestartClick()
    {
        SceneManager.LoadScene("Game");
    }
    public void StageClick()
    {
        UIManager.UInum = 0;
        SceneManager.LoadScene("Stage");
    }
    public void Song1Click()
    {
        SceneManager.LoadScene("Song1");
    }
    public void Song2Click()
    {
        SceneManager.LoadScene("Song3");
    }
    public void Song3Click()
    {
        SceneManager.LoadScene("Song2");
    }
}