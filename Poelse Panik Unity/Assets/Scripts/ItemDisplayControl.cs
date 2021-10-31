using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayControl : MonoBehaviour
{
    public Image itemImage;
    public string itemString;
    Dictionary<string, int> itemsDict = new Dictionary<string, int>();
    Dictionary<string, int> itemsDict2 = new Dictionary<string, int>();
    Items itemsRef;
    GameObject gameManager;
    public bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDict = itemsRef.ItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        itemsDict2 = itemsRef.ItemsDict;

        if (DetectUpdate(itemsDict, itemsDict2, firstTime) == true)
        {
            DisplayItem(itemString, itemImage, itemsDict);
            firstTime = false;
            itemsDict = itemsRef.ItemsDict;
        }
    }

    public bool DetectUpdate(Dictionary<string, int> dict, Dictionary<string, int> dict2, bool firstTime)
    {
        if (firstTime == true)
        {
            return true;
        }

        else
        {
            if (dict.Equals(dict2) != true)
            {
                Debug.Log("Change found");
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    public void DisplayItem(string itemString, Image itemImg, Dictionary<string, int> Dict)
    {
        if (Dict[itemString] == 0)
        {
            itemImg.gameObject.SetActive(false);
        }

        else if (Dict[itemString] > 0)
        {
            itemImg.gameObject.SetActive(true);
        }
    }

    public void MakeClone(Dictionary<string, int> dict, Dictionary<string, int> dict2)
    {
        foreach (KeyValuePair<string, int> entry in dict)
        {
            dict2.Add(entry.Key, entry.Value);
        }
    }
}
