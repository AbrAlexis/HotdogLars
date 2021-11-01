using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;



public class BestillingsTjekker : MonoBehaviour
{
    //PlayerOrdrer playerOrdrerRef;
    Items itemsRef;
    GameObject gameManager;
    public Dictionary<string, int> PlayerDic = new Dictionary<string, int>();
    public Dictionary<string, int> NpcDic = new Dictionary<string, int>();


    public bool BestillingerEns = false;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        //playerOrdrerRef = gameManager.GetComponent<PlayerOrdrer>();
        itemsRef = gameManager.GetComponent<Items>();
        PlayerDic = itemsRef.PlayerItemsDict;
        NpcDic = itemsRef.ItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompareOrders()
    {
        bool isEqual = Enumerable.SequenceEqual(PlayerDic, NpcDic);
        BestillingerEns = isEqual;
    }
        
}
   