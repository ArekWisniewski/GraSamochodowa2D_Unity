using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

public GameObject menuButtons;
public GameObject settingsMenu;

    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionsButton()
    {
        menuButtons.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}
