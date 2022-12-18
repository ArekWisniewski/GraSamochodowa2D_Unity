using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public GameObject menu;
    public Slider volume;

    void Start()
    {   
        volume.value = AudioListener.volume;
        volume.onValueChanged.AddListener(delegate { OnVolumeValueChange(); });    
    }
    public void OnVolumeValueChange()
    {
        AudioListener.volume = volume.value;
    }

    public void OnButtonClick()
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }
}