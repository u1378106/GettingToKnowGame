using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject introText;
    ObjectSpawner objectSpawner;
    CharacterMovement characterMovement;
    public Text personalityText;
    public GameObject personalityImg;

    // Start is called before the first frame update
    void Start()
    {
        objectSpawner = GameObject.FindObjectOfType<ObjectSpawner>();
        objectSpawner.CancelInvoke();
        objectSpawner.enabled = false;

        characterMovement = GameObject.FindObjectOfType<CharacterMovement>();
        characterMovement.enabled = false;

        introText.SetActive(true);
        personalityImg.SetActive(false);
        personalityText.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        introText.SetActive(false);
        objectSpawner.enabled = true;
        objectSpawner.StartSpawningObjects();
        characterMovement.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(characterMovement.blueColorCounter == 3)
        {
            personalityText.gameObject.SetActive(true);
            personalityImg.SetActive(true);
            personalityText.text = "You have chosen Blue Color. You are Trustworthy, Dependable and Strengthful!";
            characterMovement.enabled = false;
           
            objectSpawner.CancelInvoke();
        }

        else if(characterMovement.greenColorCounter == 3)
        {
            personalityText.gameObject.SetActive(true);
            personalityImg.SetActive(true);
            personalityText.text = "You have chosen Green Color. You are Peaceful, Leader and Generous!";
            characterMovement.enabled = false;
            objectSpawner.CancelInvoke();
        }

        else if(characterMovement.redColorCounter == 3)
        {
            personalityText.gameObject.SetActive(true);
            personalityImg.SetActive(true);
            personalityText.text = "You have chosen Red Color. You are Youtful, Excited and Bold!";
            characterMovement.enabled = false;
            objectSpawner.CancelInvoke();
        }
    }
}
