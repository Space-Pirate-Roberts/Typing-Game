using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreTable : MonoBehaviour
{
    public Canvas highScoreCanvas, outroCanvas;
    
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<Transform> highScoreEntryTransformList;
    private void Awake()
    {
        outroCanvas.enabled = false;
        
        entryContainer = transform.Find("highScoreEntryContainer");
        entryTemplate = entryContainer.Find("highScoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        AddHighScoreEntry(PlayerPrefs.GetInt("Score", 0), PlayerPrefs.GetString("Name", "Anonymous"));
        string jsonString = PlayerPrefs.GetString("highScoreTable","");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        for (int i = 0; i < highscores.highScoreEntryList.Count; i++)
        {
            for (int j = i+i; j < highscores.highScoreEntryList.Count; j++)
            {
                if (highscores.highScoreEntryList[j].score > highscores.highScoreEntryList[i].score)
                {
                    HighScoreEntry tmp = highscores.highScoreEntryList[i];
                    highscores.highScoreEntryList[i] = highscores.highScoreEntryList[j];
                    highscores.highScoreEntryList[j] = tmp;
                }
            }
        }


        highScoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highScoreEntry in highscores.highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }

    }

    private void CreateHighScoreEntryTransform(HighScoreEntry highScoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 20f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default: rankString = rank + "TH"; break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }
        entryTransform.Find("posText").GetComponent<Text>().text = rankString;

        int score = highScoreEntry.score;
        entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

        string name = highScoreEntry.name;
        entryTransform.Find("nameText").GetComponent<Text>().text = name;

        entryTransform.Find("background").gameObject.SetActive(rank % 2 == 1);
        if (rank == 1)
        {
            entryTransform.Find("posText").GetComponent<Text>().GetComponent<Text>().color = Color.green;
            entryTransform.Find("scoreText").GetComponent<Text>().GetComponent<Text>().color = Color.green;
            entryTransform.Find("nameText").GetComponent<Text>().GetComponent<Text>().color = Color.green;
        }
        transformList.Add(entryTransform);

    }

    private void AddHighScoreEntry (int score, string name)
    {
        //create HighScoreEntry
        HighScoreEntry highscoreEntry = new HighScoreEntry { score = score, name = name };
       
        //load saved Highscores
        string jsonString = PlayerPrefs.GetString("highScoreTable", "");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        //add new entry to Highscores
        highscores.highScoreEntryList.Add(highscoreEntry);

        //limit 10
        while (highscores.highScoreEntryList.Count >10)
        {
            highscores.highScoreEntryList.RemoveAt(10);
        }
        
        //save updated Highscores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highScoreTable", json);
        PlayerPrefs.Save();
    }

    public void ClearHighScores()
    {
        //load saved Highscores
        string jsonString = PlayerPrefs.GetString("highScoreTable", "");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        //erase
        while (highscores.highScoreEntryList.Count > 0)
        {
            highscores.highScoreEntryList.RemoveAt(0);
        }
        //save updated Highscores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highScoreTable", json);
        PlayerPrefs.Save();

        //reload scene to clear displayed high score table
        SceneManager.LoadScene(2);
    }

    public void pressContinue()
    {
        outroCanvas.enabled = true;
        highScoreCanvas.enabled = false;
    }

    private class Highscores
    {
        public List<HighScoreEntry> highScoreEntryList;
    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int score;
        public string name;
    }
}
