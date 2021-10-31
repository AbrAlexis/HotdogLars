using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class BestillingsTjekker : MonoBehaviour
{
    //PlayerOrdrer playerOrdrerRef;
    NPCBestilling NPCBestillingRef;
    GameObject gameManager;

    public bool BestillingerEns = false;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        //playerOrdrerRef = gameManager.GetComponent<PlayerOrdrer>();
        NPCBestillingRef = gameManager.GetComponent<NPCBestilling>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompareOrders()
    {
        //bool isEqual = Enumerable.SequenceEqual(playerOrdrerRef.ordrer, NPCBestillingRef.NPCordrer);
        //BestillingerEns = isEqual;
    }
        
}
   