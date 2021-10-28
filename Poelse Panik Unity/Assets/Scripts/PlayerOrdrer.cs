using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PlayerOrdrer : MonoBehaviour {


    public Text ordreText;
    public List<string> ordrer = new List<string>();
    void Start()
    {
        
    }

    public void DisplayOrdrer()
    {
        // T�ller antal af de samme iteams i en liste og laver et dictionary af resultatet
        ordrer.Sort();
        var dictionary = ordrer.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => x.Key, y => y.Count());

        Dictionary<string, int> ordrerDic = new Dictionary<string, int>();
        ordrerDic = dictionary;

        // G�r i gennem dictionary'et og laver en streng som vises 
        string NPC_Bestilling_Streng = "";
        foreach (KeyValuePair<string, int> item in ordrerDic)
        {
            NPC_Bestilling_Streng = NPC_Bestilling_Streng + item.Value + " " + item.Key + ", ";
        }

        // Fjerner de sidste to karakterer i stregen s� der ikke st�r ", " tilsidst
        NPC_Bestilling_Streng = NPC_Bestilling_Streng.Remove(NPC_Bestilling_Streng.Length - 2);

        ordreText.text = NPC_Bestilling_Streng;
    }
    void Update()
    {
    }
   

    public void Tilf�jIngrediens(string a) {
        ordrer.Add(a);
        DisplayOrdrer();

    }

    public void SletIngrediens(string a)
    {
        ordrer.Remove(a);
        DisplayOrdrer();
    }


}
