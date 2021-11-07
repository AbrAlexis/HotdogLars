using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject MenuPanel;
    GameObject gameManager;
    LevelManager LevelManagerRef;
    public Sprite StartGreenSprite;
    public Image StartImg;
    Items itemsRef;
    GameObject timer;
    Timer timerRef;
    public Image NPCFrame;
    public Image GameOver;
    BestillingsTjekker bestillingsTjekkerRef;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        timer = GameObject.Find("Timer");
        LevelManagerRef = gameManager.GetComponent<LevelManager>();
        itemsRef = gameManager.GetComponent<Items>();
        timerRef = timer.GetComponent<Timer>();
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        itemsRef.Chooseitems(2);
        itemsRef.ChooseNumOfItems();
        MenuPanel.SetActive(false);
        LevelManagerRef.GameOn = true;
    }

    public void ChangePic()
    {
        StartImg.sprite = StartGreenSprite;
    }

    public void RestartGame()
    {
        bestillingsTjekkerRef.BestillingerEns = false;
        itemsRef.ResetItemsCount();
        itemsRef.ResetItemsCountPlayer();

        foreach (var value in itemsRef.ItemsDict.Values)
        {
            print(value);
        }

        itemsRef.Chooseitems(2);
        itemsRef.ChooseNumOfItems();
        LevelManagerRef.lives = 3;
        LevelManagerRef.Hardness = 2;
        timerRef.timeRemaining = 11f;
        timerRef.DisableButtons();
        NPCFrame.gameObject.SetActive(true);
        GameOver.gameObject.SetActive(false);
        LevelManagerRef.GameOn = true;
    }

}
