using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_game_manager : MonoBehaviour
{
    //Declare a variable INT
    public int hpValue, sanityValue;
    //Declare a variable textmeshpro
    public TextMeshProUGUI hpTextValue, sanityTextValue, storyTextValue;
    //Declare a variable string
    public string startOfStory;
    //Declare game object
    public GameObject level1_Choices, HpTextGO, HpValueGO, SanityTextGO, SanityValueGO, MainMenuGO;

    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        startOfStory = "Game Title";

    }

    // Update is called once per frame
    void Update()
    {
        //Textmesh pro variable = hpvalue int
        hpTextValue.text = hpValue.ToString();
        sanityTextValue.text = sanityValue.ToString();
        storyTextValue.text = startOfStory;
    }
    public void Choice1()
    {
        hpValue -= 10;
        sanityValue -= 10;
        startOfStory = "The person in front stabs you";
        level1_Choices.SetActive(false);
    }
    public void Choice2()
    {
        sanityValue -= 1;
        startOfStory = "You are at my house";
        level1_Choices.SetActive(false);
    }
    public void Choice3()
    {
        
    }


    public void StartButton()
    {
        level1_Choices.SetActive(true);
        HpTextGO.SetActive(true);
        HpValueGO.SetActive(true);
        SanityTextGO.SetActive(true);
        SanityValueGO.SetActive(true);
        MainMenuGO.SetActive(false);
        startOfStory = "Start of the Story";
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
