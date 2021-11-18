using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    Items itemsRef;
    Timer timerRef;
    GameObject gameManager;
    GameObject Timer;
    BestillingsTjekker bestillingsTjekkerRef;
    public GameObject MenuPanel;

    public float time = 0f;
    int lives = 3;
    int Hardness = 2;
    int Level = 1;
    public bool evaluating = false;

    public Image Heart1;
    public Image Heart2;
    public Image Heart3;

    List<Image> Hearts = new List<Image>();

    public Image NPCFrame;
    public Text LevelText;
    public GameObject GameOver;


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
            timerRef.DisableButtons();
            evaluating = true;
            time += Time.deltaTime;

            if (time >= 3)
            {
                bestillingsTjekkerRef.BestillingerEns = false;
                NextLevel();
                ResetGame();
                evaluating = false;
                time = 0f;
            }
        }

        else if (bestillingsTjekkerRef.BestillingerIkkeEns == true)
        {
            timerRef.DisableButtons();
            evaluating = true;
            time += Time.deltaTime;

            if (time >= 3)
            {
                bestillingsTjekkerRef.BestillingerIkkeEns = false;
                ResetGame();
                evaluating = false;
                time = 0f;
            }
        }


        else if (lives == 0)
        {
            GameOver.SetActive(true);
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
        itemsRef.ItemsChoosen.Clear();
        itemsRef.ResetItemsCount();
        itemsRef.ResetItemsCountPlayer();
        itemsRef.Chooseitems(Random.Range(Hardness - 1, Hardness));
        itemsRef.ChooseNumOfItems();
        timerRef.timeRemaining = 11f;
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

    public void RestartGame()
    {
        lives = 3;
        Hardness = 2;
        Level = 1;

        Hearts.Clear();
        Hearts.Add(Heart1);
        Hearts.Add(Heart2);
        Hearts.Add(Heart3);

        foreach(Image Heart in Hearts)
        {
            Heart.gameObject.SetActive(true);
        }

        ResetGame();
        GameOver.SetActive(false);
        MenuPanel.SetActive(false);
    }
}