using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour {

    //Sets varaibles for the script
    public TextMeshProUGUI textDisplay;

    public string[] sentences;

    private int index;

    public float typingSpeed;

    public GameObject continueButton;
    private void Start()
    {

        StartCoroutine(Type());

    }

    void Update()
    {
        //check to see if the current display text is = to the currrent sentence
        if (textDisplay.text == sentences[index])
        {

            //displays the continue button once that sentence has been typed out
            continueButton.SetActive(true);

        }

    }

    IEnumerator Type()
    {

        foreach (char letter in sentences[index].ToCharArray())
        {
            //stest the time to wait before typing out a scentence
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }

    }

    public void NextSentence(){


        //immediatley hides the continue button after click until the dialog has ended
        continueButton.SetActive(false);

        if(index < sentences.Length - 1){

            index++;

            textDisplay.text = "";

            StartCoroutine(Type());

        }

        else
        {

            textDisplay.text = "";

            //Hides the continue button once the final text line has finished
            continueButton.SetActive(false);

        }
    }
}
