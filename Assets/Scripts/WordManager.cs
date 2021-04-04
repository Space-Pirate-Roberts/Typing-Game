using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    private bool hasActiveWord;
    private Word activeWord;

    public WordSpawner wordSpawner;
    public Text scoreDisplay;
    public Text nameDisplay;
    public int theScore;

    private void Start()
    {
        theScore = 0;
        scoreDisplay.text = theScore.ToString();
        PlayerPrefs.SetInt("Score", 0);
        nameDisplay.text = PlayerPrefs.GetString("Name", "Anonymous");
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                theScore++;
                scoreDisplay.text = theScore.ToString();
            }
            else
            {
                theScore--;
                scoreDisplay.text = theScore.ToString();

            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() ==letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    theScore++;
                    scoreDisplay.text = theScore.ToString();
                    break;
                }
            }
            theScore--;
            scoreDisplay.text = theScore.ToString();

        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
