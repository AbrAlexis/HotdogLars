using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Items : MonoBehaviour
{
    public Dictionary<string, int> ItemsDict = new Dictionary<string, int>();
    private Dictionary<string, int> PlayerItemsDict = new Dictionary<string, int>();
    private List<string> KeysLst = new List<string>();
    private List<string> ItemsChoosen = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        ItemsDict.Add("Brød", 0);
        ItemsDict.Add("Fritter", 0);
        ItemsDict.Add("Pølse", 0);
        ItemsDict.Add("Cola", 0);

        PlayerItemsDict = ItemsDict;
        ResetItemsCount();
        Chooseitems(4);
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

    public void ResetItemsCount() 
    {
        foreach(string key in ItemsDict.Keys) 
        {
            KeysLst.Add(key);

        }

        foreach(string key in KeysLst)
        {
            ItemsDict[key] = 0;
        }

    }
    string ChooseItem()
    {
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
                ItemsChoosen.Add(ChooseItem());
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
        var match = ItemsChoosen.FirstOrDefault(stringToCheck => stringToCheck.Contains(ButtonItem));

        if (match != null && PlayerItemsDict[ButtonItem] < 99)
            PlayerItemsDict[ButtonItem] += 1;
    }
}
