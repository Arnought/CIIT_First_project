using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
public class text_game_manager : MonoBehaviour
{
    //Declare a variable INT
    public int hpValue, sanityValue;
    //Declare a variable textmeshpro
    public TextMeshProUGUI hpTextValue, sanityTextValue, storyTextValue, endingTextValue;
    //Declare a variable string
    public string startOfStory, endingOfStory;
    //Declare game object
    public GameObject level1_Choices, level2_Choices, level3_Choices, HpTextGO, HpValueGO, SanityTextGO, SanityValueGO, MainMenuGO, ContinueGO, EndingGO;
    public AudioSource sfx;
    public Button start;

    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        startOfStory = "Game Title";

    }

    public void PlayClickSound()
    {
        sfx.Play();
    }

    public void StartButton()
    {
        level1_Choices.SetActive(false);
        HpTextGO.SetActive(false);
        HpValueGO.SetActive(false);
        SanityTextGO.SetActive(false);
        SanityValueGO.SetActive(false);
        MainMenuGO.SetActive(false);
        ContinueGO.SetActive(true);
        startOfStory = "As the shipwreck survivor, you wash ashore on a deserted island, surrounded by lush vegetation and pristine beaches. The sun begins to set, casting long shadows across the landscape. With no immediate means of rescue, you must find a way to escape the island.";
    
        start = GetComponent<Button>();
        sfx = GetComponent<AudioSource>();

        start.onClick.AddListener(PlayClickSound);
    
    }

    public void ContinueButton()
    {
        level1_Choices.SetActive(true);
        HpTextGO.SetActive(true);
        HpValueGO.SetActive(true);
        SanityTextGO.SetActive(true);
        SanityValueGO.SetActive(true);
        MainMenuGO.SetActive(false);
        ContinueGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Textmesh pro variable = hpvalue int
        hpTextValue.text = hpValue.ToString();
        sanityTextValue.text = sanityValue.ToString();
        storyTextValue.text = startOfStory;
        endingTextValue.text = endingOfStory;
    }
    public void Choice1()
    {
        startOfStory = "You encountered a wild boar. What will you do?";
        level1_Choices.SetActive(false);
        level2_Choices.SetActive(true);


    }
    public void Choice2()
    {
        startOfStory = "You found a boat and an unconcious guy. What will you do?";
        level1_Choices.SetActive(false);
        level3_Choices.SetActive(true);

    }
    public void Fight_Choice()
    {
        hpValue -= 10;
        sanityValue -= 10;
        startOfStory = "The boar killed you.";
        endingOfStory = "Bad Ending";
        level2_Choices.SetActive(false);
        EndingGO.SetActive(true);
    }
    public void Run_Choice()
    {
        startOfStory = "While running you found a village, you explained your situation and they are willing to help you.";
        endingOfStory = "Good Ending";
        level2_Choices.SetActive(false);
        EndingGO.SetActive(true);
    }
    public void Wakeup()
    {
        startOfStory = "After waking up the unconcious guy, he tells you about what happened before the both of you end up in the deserted island, and since you found a boat the both of you fixed it and leave the island";
        endingOfStory = "Good Ending";
        level3_Choices.SetActive(false);
    }
    public void Leave()
    {
        startOfStory = "You ride the boat and escaped the island but, after an hour you noticed that the water is going inside the boat and will eventually sink. Without means to fix the boat you end up dying in the sea.";
        endingOfStory = "Bad Ending";
        level3_Choices.SetActive(false);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
