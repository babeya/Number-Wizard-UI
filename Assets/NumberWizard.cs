using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour 
{
	int max;
	int min;
    int guess;
    int maxGuessesAllowed = 10;

    public Text text;

	void Start () 
    {
        StartGame();
	}

    public void guessHigher() 
    {
		min = guess;
		NextGuess();
    }

    public void guessLower() {
        max = guess;
        NextGuess();
    }

	void NextGuess()
	{
        maxGuessesAllowed--;

        if (maxGuessesAllowed <= 0) { // Lose condition 
            SceneManager.LoadScene("Lose");
        }

        guess = Random.Range(min, max);
        text.text = guess.ToString();

        if (min == max) { // Cheater case 
        
        }
	}
	
    void StartGame()
	{
		max = 1000;
		min = 1;
        max = max + 1;

        guess = Random.Range(min, max);
        text.text = guess.ToString();
	}
}
