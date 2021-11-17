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
    public List<string> Ens = new List<string>();
    public List<string> IkkeEns = new List<string>();
    public bool BestillingerEns = false;
    public bool BestillingerIkkeEns = false;

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

        if (isEqual == true)
        {
            BestillingerEns = true;
            BestillingerIkkeEns = false;
        }

        else
        {
            BestillingerEns = false;
            BestillingerIkkeEns = true;
        }
    }

    public void FindRightAndWrong()
    {
        Ens.Clear();
        IkkeEns.Clear();

        foreach (var key in itemsRef.ItemsDict.Keys)
        {
            if (itemsRef.ItemsDict[key] == itemsRef.PlayerItemsDict[key])
            {
                Ens.Add(key);
            }
            
            else
            {
                IkkeEns.Add(key);
            }
        }
    }
}
   