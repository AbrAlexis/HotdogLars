using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Items : MonoBehaviour
{
    public Dictionary<string, int> ItemsDict = new Dictionary<string, int>();
    public Dictionary<string, int> PlayerItemsDict = new Dictionary<string, int>();
    List<string> KeysLst = new List<string>();
    List<string> ItemsChoosen = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        ItemsDict.Add("Br�d", 0);
        ItemsDict.Add("Fritter", 0);
        ItemsDict.Add("P�lse", 0);
        ItemsDict.Add("Cola", 0);
        ItemsDict.Add("L�g", 0);
        ItemsDict.Add("SyltedeAgurker", 0);
        ItemsDict.Add("Cocio", 0);


        PlayerItemsDict.Add("Br�d", 0);
        PlayerItemsDict.Add("Fritter", 0);
        PlayerItemsDict.Add("P�lse", 0);
        PlayerItemsDict.Add("Cola", 0);
        PlayerItemsDict.Add("L�g", 0);
        PlayerItemsDict.Add("SyltedeAgurker", 0);
        PlayerItemsDict.Add("Cocio", 0);

        Chooseitems(7);
        ChooseNumOfItems();
    }

    // Update is called once per frame
    void Update()
    {
        //printDict();
    }

    void printDict()
    {
        foreach(int value in PlayerItemsDict.Values)
        {
            print(value);
        }
    }

    void GetKeys()
    {
        foreach (string key in ItemsDict.Keys)
        {
            KeysLst.Add(key);

        }
    }

    public void ResetItemsCount() 
    {
        GetKeys();

        foreach (string key in KeysLst)
        {
            ItemsDict[key] = 0;
        }

    }
    string ChooseItem()
    {
        GetKeys();

        string item = KeysLst[Random.Range(0, KeysLst.Count)];
        return item;
    }

    void Chooseitems(int NumItemsWanted)
    {
        int lenght = 0;

        while (lenght < NumItemsWanted)
        {
            string itemChoosen = ChooseItem();
            var match = ItemsChoosen.Contains(itemChoosen);

            if (match == false)
            {
                ItemsChoosen.Add(itemChoosen);
                Debug.Log(itemChoosen);
            }

            lenght = ItemsChoosen.Count();
        } 
    }

    void ChooseNumOfItems()
    {
        foreach(string Item in ItemsChoosen)
        {
            ItemsDict[Item] = Random.Range(1, 5);
        }
    }
    public void AddInventoryItem(string ButtonItem)
    {
        if (PlayerItemsDict[ButtonItem] < 99)
        {
            PlayerItemsDict[ButtonItem] += 1;
        }
    }
    
}
