using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public Button startButton;
    public Canvas startCanvas;
    public InputField playerNameInput;
    public Slider spawnRateSlider, fallSpeedSlider;
        
    void Start()
    {
        startCanvas.enabled = false;
    }

    public void OkayToStart()
    {
        startCanvas.enabled = true;
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("Name", playerNameInput.text);
        PlayerPrefs.SetFloat("SpawnRate", 3f - spawnRateSlider.value);
        PlayerPrefs.SetFloat("FallSpeed", fallSpeedSlider.value);
        
        SceneManager.LoadScene(1);
    }
    
}
