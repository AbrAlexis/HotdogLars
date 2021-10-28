using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCBestilling : MonoBehaviour
{
    public List<string> NPCordrer = new List<string>();

    void Start()
    {
       // TilfældigIngrediens();
        OrdrerGenerering(5);
    }

 
    void Update()
    {
        
    }
    public Text NPCordrerText;

    
    public void OrdrerGenerering(int a)
    {
       

        
        for (int i = 0; i < a; i++)
        {
            NPCordrer.Add(TilfældigIngrediens());
            
        }



        string NPC_Bestilling_Streng = "";
        NPCordrer.Sort();
        for (int i = 0; i < NPCordrer.Count; i++)
        {
            NPC_Bestilling_Streng = NPC_Bestilling_Streng + NPCordrer[i] + " ";
            NPCordrerText.text = NPC_Bestilling_Streng;
        }

            
        NPCordrerText.text = NPC_Bestilling_Streng;
    }

    public string TilfældigIngrediens()
    {
        string[] ingredienser = {"Pølse", "Brød", "Cola", "Fritter"};
        string randIng = ingredienser[Random.Range(0, ingredienser.Length)];
        Debug.Log(randIng);
        return randIng;
       

    }

}

