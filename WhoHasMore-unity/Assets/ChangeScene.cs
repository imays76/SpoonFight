using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene: MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("scene1");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("scene0");
    }

    public void Credit()
    {
        SceneManager.LoadScene("credit");
    }
}
