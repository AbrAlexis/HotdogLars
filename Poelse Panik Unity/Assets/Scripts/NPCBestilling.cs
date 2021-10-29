using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class NPCBestilling : MonoBehaviour
{
    public List<string> NPCordrer = new List<string>();
    Timer timerRef;
    GameObject gameManager;
    public Text NPCordrerText;

    public class item
    {
        public string name;
        public int count;
        public Text text;

        public item(string Name, Text Text)
        {
            name = Name;
            count = 0;
            text = Text;
        }

    }


    void Start()
    {
       // Tilf�ldigIngrediens();
        gameManager = GameObject.Find("GameManager");
        timerRef = gameManager.GetComponent<Timer>();
    }

 
    void Update()
    {
        HideBestilling();
    }

    
    public void OrdrerGenerering(int a)
    {

        for (int i = 0; i < a; i++)
        {
            NPCordrer.Add(Tilf�ldigIngrediens());
        }


        NPCordrer.Sort();

        // T�ller antal af de samme iteams i en liste og laver et dictionary af resultatet
        var dictionary = NPCordrer.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => x.Key, y => y.Count());


        Dictionary<string, int> NPCordrerDic = new Dictionary<string, int>();
        NPCordrerDic = dictionary;

        // G�r i gennem dictionary'et og laver en streng som vises 
        string NPC_Bestilling_Streng = "";
        foreach (KeyValuePair<string, int> item in NPCordrerDic)
        {
            NPC_Bestilling_Streng = NPC_Bestilling_Streng + item.Value + " " + item.Key + ", ";
        }
        
        // Fjerner de sidste to karakterer i stregen s� der ikke st�r ", " tilsidst
        NPC_Bestilling_Streng = NPC_Bestilling_Streng.Remove(NPC_Bestilling_Streng.Length - 2);
        NPCordrerText.text = NPC_Bestilling_Streng;
    }

    public string Tilf�ldigIngrediens()
    {
        // V�lger en tilf�ldig ingredise og returner den
        string[] ingredienser = {"P�lse", "Br�d", "Cola", "Fritter"};
        string randIng = ingredienser[Random.Range(0, ingredienser.Length)];
        return randIng;
       

    }

    void HideBestilling()
    {
        if (timerRef.timeRemaining <= 0)
        {
            NPCordrerText.gameObject.SetActive(false);
        }
    }

}

