using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    //Text components used to display the high scores
    public List<Text> highScoreDisplays = new List<Text>();

    //Internal data for score values
    private List<int> highScoreData = new List<int>();

    // Use this for initialization
    void Start()
    {

        //Load hgh score data from the PlayerPrefs
        LoadHighScoredata();

        //Get current score from PlayerPrefs
        int currentScore = PlayerPrefs.GetInt("score", 0);

        //Check if got a new high score
        bool haveNewHighScore = IsNewHighScore(currentScore);
        if (haveNewHighScore == true)
        {

            //Add new score to the data
            AddScoreToList(currentScore);

            //Save updated data
            SaveHighScoredata();

        }


        //Update the visual display
        UpdateVisualDisplay();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LoadHighScoredata()
    {

        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {

            //Using the loop index, get the name for PlayerPrefs key
            string prefsKey = "highScore" + i.ToString();

            //Use this key to get the hgh score from the PlayerPrefs
            int highScoreValue = PlayerPrefs.GetInt(prefsKey, 0);

            //Store this score value in out internal data list
            highScoreData.Add(highScoreValue);

        }

    }

    //Update the visual display
    private void UpdateVisualDisplay()
    {
        //Goes trhough the loop the same amount of times there are visual displays
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            //Find the specific text and numbers in our list
            //and set the text to the numerical score
            highScoreDisplays[i].text = highScoreData[i].ToString();

        }

    }

    //checks for new high score
    private bool IsNewHighScore(int scoreToCheck)
    {
        //looping through the high scores and see if it is higher than any of them
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            //Is our score higher than the high score checking this loop
            if (scoreToCheck > highScoreData[i])
            {
                //Score is higher!
                //Return to the calling code that ther is new high score
                return true;
            }

        }

        //default: false 
        //did not find any scores that score was higher 
        return false;

    }

    private void AddScoreToList(int newScore)
    {
        //Loop throug the high scores and find where the new score fits
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            //Is score hgher than one current on list
            if (newScore > highScoreData[i])
            {

                //The score IS Higher
                //as the score is higher than all previous ones, this one must come first

                //Insert the new score into the list here
                highScoreData.Insert(i, newScore);

                //Trim the last item off the list
                highScoreData.RemoveAt(highScoreData.Count - 1);

                //finished the loop 
                return;

            }


        }

    }

    private void SaveHighScoredata()
    {

        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {

            //Using the loop index, get the name for PlayerPrefs key
            string prefsKey = "highScore" + i.ToString();

            //Get the curent high score entry from the data
            int highScoreEntry = highScoreData[i];

            //Save this data to the PlayerPrefs
            PlayerPrefs.SetInt(prefsKey, highScoreEntry);

        }

        //Save the player prefs to disk
        PlayerPrefs.Save();


    }


}
