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
    public List<string> ItemsChoosen = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
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
        foreach (var key in ItemsDict.Keys.ToList())
        {
            ItemsDict[key] = 0;
        }

    }

    public void ResetItemsCountPlayer()
    {
        foreach (var key in PlayerItemsDict.Keys.ToList())
        {
            PlayerItemsDict[key] = 0;
        }
    }


    string ChooseItem()
    {
        KeysLst = ItemsDict.Keys.ToList();
        string item = KeysLst[Random.Range(0, KeysLst.Count)];
        return item;
    }

    public void Chooseitems(int NumItemsWanted)
    {
        int lenght = 0;

        while (lenght < NumItemsWanted)
        {
            string itemChoosen = ChooseItem();
            var match = ItemsChoosen.Contains(itemChoosen);

            if (match == false)
            {
                ItemsChoosen.Add(itemChoosen);
            }

            lenght = ItemsChoosen.Count();
        } 
    }

    public void ChooseNumOfItems()
    {
        foreach(string Item in ItemsChoosen)
        {
            ItemsDict[Item] = Random.Range(1, 6);
        }
    }
    public void AddInventoryItem(string ButtonItem)
    {
        if (PlayerItemsDict[ButtonItem] < 99)
        {
            PlayerItemsDict[ButtonItem] += 1;
        }
    }

    public void RemoveItem(string ButtonItem)
    {
        PlayerItemsDict[ButtonItem] -= 1;
    }

    
}
