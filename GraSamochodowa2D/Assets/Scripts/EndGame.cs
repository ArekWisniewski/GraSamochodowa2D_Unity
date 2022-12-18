using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndGame : MonoBehaviour {

    public Text gainedPointsText;
	void Start () 
    {
        gainedPointsText.text = PointsManager.points.ToString();
    }

    public void RetryButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void MenuExitButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}