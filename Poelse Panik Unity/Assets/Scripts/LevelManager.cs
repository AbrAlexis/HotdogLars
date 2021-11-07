using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    Items itemsRef;
    Timer timerRef;
    public Image NPCFrame;
    GameObject gameManager;
    GameObject Timer;
    BestillingsTjekker bestillingsTjekkerRef;
    float time = 0f;
    public int lives = 3;
    public int Hardness = 2;
    int Level = 1;

    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    List<Image> Hearts = new List<Image>();
    
    public Text LevelText;
    public GameObject GameOver;
    public bool GameOn = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        Timer = GameObject.Find("Timer");
        itemsRef = gameManager.GetComponent<Items>();
        timerRef = Timer.GetComponent<Timer>();
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
        Hearts.Add(Heart1);
        Hearts.Add(Heart2);
        Hearts.Add(Heart3);
        itemsRef.ItemsDict.Add("Brød", 0);
        itemsRef.ItemsDict.Add("Fritter", 0);
        itemsRef.ItemsDict.Add("Pølse", 0);
        itemsRef.ItemsDict.Add("Cola", 0);
        itemsRef.ItemsDict.Add("Løg", 0);
        itemsRef.ItemsDict.Add("SyltedeAgurker", 0);
        itemsRef.ItemsDict.Add("Cocio", 0);
        itemsRef.PlayerItemsDict.Add("Brød", 0);
        itemsRef.PlayerItemsDict.Add("Fritter", 0);
        itemsRef.PlayerItemsDict.Add("Pølse", 0);
        itemsRef.PlayerItemsDict.Add("Cola", 0);
        itemsRef.PlayerItemsDict.Add("Løg", 0);
        itemsRef.PlayerItemsDict.Add("SyltedeAgurker", 0);
        itemsRef.PlayerItemsDict.Add("Cocio", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (bestillingsTjekkerRef.BestillingerEns == true)
        {
            time += Time.deltaTime;

            if (time >= 3)
            {
                bestillingsTjekkerRef.BestillingerEns = false;
                time = 0f;
                NextLevel();
                ResetGame();
            }
        } 
        
        else if (lives == 0)
        {
            GameOver.SetActive(true);
            GameOn = false;
        }

    }

    public void NextLevel()
    {       
            if (Hardness < 7)
            {
                Hardness += 1;
            }

            Level += 1;
            LevelText.text = "Level " + Level;
    }

    public void ResetGame()
    {
        itemsRef.ResetItemsCount();
        itemsRef.ResetItemsCountPlayer();
        itemsRef.Chooseitems(Random.Range(2, Hardness + 1));
        itemsRef.ChooseNumOfItems();
        timerRef.timeRemaining = 10f;
        timerRef.DisableButtons();
        NPCFrame.gameObject.SetActive(true);
    }

    public void Lives()
    {
        if (bestillingsTjekkerRef.BestillingerEns == false)
        {
            lives -= 1;
            Hearts[0].gameObject.SetActive(false);
            Hearts.RemoveAt(0);

        }
    }
}