using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void HighScoreButton()
    {
        //SceneManager.LoadScene(2);
    }

    public void OptionsButton()
    {
        //SceneManager.LoadScene(3);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
