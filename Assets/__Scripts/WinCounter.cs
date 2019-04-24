using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCounter : MonoBehaviour
{
    public List<GameObject> enemyTanks;
    //public Text uiChef;
    //public Text uiPilote;
    public Text uiTireur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int tankcount=0;
        foreach (GameObject e in enemyTanks){
            if (e.active) tankcount++;
        }

        if (tankcount == 0)
        {
            //uiChef.text = "Vous avez éliminé tous les ennemis! Bravo!";
            //uiPilote.text = "Vous avez éliminé tous les ennemis! Bravo!";
            uiTireur.text = "Vous avez éliminé tous les ennemis! Bravo!";
            //Win function
        }
        else
        {
            //uiChef.text = "Il reste " + tankcount + " ennemis";
            //uiPilote.text = "Il reste " + tankcount + " ennemis";
            uiTireur.text = "Il reste " + tankcount + " ennemis";
            //Afficher le nombe de tanks restants
        }
    }
}
