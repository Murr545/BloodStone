using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceScript : MonoBehaviour
{
    [SerializeField] GameObject InventoryMenu;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject HeroStatMenu;

    bool IsMainMenuOn;
    bool IsInventoryOn;
    bool IsHeroStatMenuOn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        {
            if(IsInventoryOn == false && IsMainMenuOn == false) 
            {
                IsInventoryOn = true;
                InventoryMenu.SetActive(true);
            }
            else
            {
                IsInventoryOn = false;
                InventoryMenu.SetActive(false);
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsMainMenuOn == false)
            {
                IsMainMenuOn = true;
                IsInventoryOn = false;
                IsHeroStatMenuOn = false;
                InventoryMenu.SetActive(false);
                HeroStatMenu.SetActive(false);
                MainMenu.SetActive(true);
            }
            else
            {
                IsMainMenuOn = false;
                MainMenu.SetActive(false);
            }
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(IsHeroStatMenuOn == false && IsMainMenuOn == false)
            {
                IsHeroStatMenuOn = true;
                HeroStatMenu.SetActive(true);
            }
            else
            {
                IsHeroStatMenuOn = false;
                HeroStatMenu.SetActive(false);
            }            
        }
    }
}
