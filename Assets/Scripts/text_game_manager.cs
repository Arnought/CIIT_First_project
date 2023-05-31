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
    public GameObject level1_Choices;

    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        startOfStory = "Hello there";
        
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
        hpValue -= 3;
        sanityValue -= 2;
        startOfStory = "The person in front stabs you";
        level1_Choices.SetActive(false);
    }
    public void Choice2()
    {
        sanityValue -= 1;
        startOfStory = "You are at my house";
    }
    public void Choice3()
    {

    }

}
