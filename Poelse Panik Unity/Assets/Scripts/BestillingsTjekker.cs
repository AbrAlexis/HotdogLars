using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class BestillingsTjekker : MonoBehaviour
{
    PlayerOrdrer playerOrdrerRef;
    NPCBestilling NPCBestillingRef;

    GameObject gameManager;

    
    public List<string> testliste = new List<string>();
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        playerOrdrerRef = gameManager.GetComponent<PlayerOrdrer>();
        NPCBestillingRef = gameManager.GetComponent<NPCBestilling>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Main()
    {
        
        if (true)
        {
          //  Console.WriteLine("Lists are Equal");
        }
        else
        {
            //Console.WriteLine("Lists are not Equal");
        }
   
        
        }

    public void CompareOrders()
    {
        bool isEqual = Enumerable.SequenceEqual(playerOrdrerRef.ordrer, NPCBestillingRef.NPCordrer);
        print(isEqual);
    }
        
}
   