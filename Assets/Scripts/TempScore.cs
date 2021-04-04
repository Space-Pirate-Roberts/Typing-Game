using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempScore : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }
}