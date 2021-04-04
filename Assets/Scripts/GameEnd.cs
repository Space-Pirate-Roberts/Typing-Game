using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public WordManager wordManager;
    private void OnTriggerEnter2D()
    {
        PlayerPrefs.SetInt("Score", wordManager.theScore);
        SceneManager.LoadScene(2);

        //Debug.Log("Game Lost");
    }
}
