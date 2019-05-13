using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{

    public static int UInum = 0;
    public GameObject UI1;

    public void Update()
    {
        if (UIManager.UInum == 0)
        {
            StartCoroutine(UI1spawn());
        }

        if (UIManager.UInum == 2)
        {
            StartCoroutine(StageScene());
        }
    }

    IEnumerator UI1spawn()
    {
        UIManager.UInum += 1;
        Instantiate(UI1);
        yield return null;
    }
    IEnumerator StageScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Stage");
        yield return null;
    }
}
