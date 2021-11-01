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

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        Timer = GameObject.Find("Timer");
        itemsRef = gameManager.GetComponent<Items>();
        timerRef = Timer.GetComponent<Timer>();
        bestillingsTjekkerRef = gameManager.GetComponent<BestillingsTjekker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bestillingsTjekkerRef.BestillingerEns == true)
        {
            float time = 0f;
            time += Time.deltaTime;
            Debug.Log("ok");
            bestillingsTjekkerRef.BestillingerEns = false;
        }
    
    }

    public void NextLevel()
    {

    }

    public void ResetGame()
    {
        itemsRef.ResetItemsCount();
        itemsRef.ResetItemsCountPlayer();
        itemsRef.Chooseitems(4);
        itemsRef.ChooseNumOfItems();
        timerRef.timeRemaining = 10f;
        timerRef.DisableButtons();
        NPCFrame.gameObject.SetActive(true);
    }

}
