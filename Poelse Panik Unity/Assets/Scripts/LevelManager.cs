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
    public float time = 0f;
    public int lives;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        Timer = GameObject.Find("Timer");
        itemsRef = gameManager.GetComponent<Items>();
        timerRef = Timer.GetComponent<Timer>();
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (bestillingsTjekkerRef.BestillingerEns == true)
        {

            time += Time.deltaTime;

            if (time >= 5)
            {
                bestillingsTjekkerRef.BestillingerEns = false;
                time = 0f;
                ResetGame();
            }
        } 
        
        else if (lives == 0)
        {
            print(lives);
            print("Game Over");
        }

    }

    public void NextLevel()
    {

    }

    public void ResetGame()
    {
        itemsRef.ResetItemsCount();
        itemsRef.ResetItemsCountPlayer();
        itemsRef.Chooseitems(2);
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
            print(lives);
        }
    }
}