using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OtherInventoryScript : MonoBehaviour
{
   [SerializeField] GameObject OtherInventoryIcon;
   [SerializeField] ItemParams[] Item;
   [SerializeField] string ObjectName;
   [SerializeField] bool IsLoked;

   void OnMouseDown()
   {
      if(OtherInventoryIcon.activeSelf == false)
      {
       if(IsLoked == false)
       {
         OtherInventoryIcon.SetActive(true);
         GameObject.Find("InventoryName").GetComponent<TextMeshProUGUI>().text = ObjectName;
         for(int i=0; i < 7; i++)
         {
            GameObject.Find($"ItemName{i+1}").GetComponent<TextMeshProUGUI>().text = "";
            GameObject.Find($"ItemPrice{i+1}").GetComponent<TextMeshProUGUI>().text = "";
            GameObject.Find($"ItemImage{i+1}").GetComponent<RawImage>().enabled = false;
         }
         for(int i = 0; i < Item.Length - 1; i++)
         {
            GameObject.Find($"ItemImage{i+1}").GetComponent<RawImage>().enabled = true;
            GameObject.Find($"ItemName{i+1}").GetComponent<TextMeshProUGUI>().text = Item[i].title;
            GameObject.Find($"ItemPrice{i+1}").GetComponent<TextMeshProUGUI>().text = Item[i].price.ToString();
            GameObject.Find($"ItemImage{i+1}").GetComponent<RawImage>().texture = Item[i].image;
         }
       }
       else
       {
         GameObject.Find("LockedInformation").GetComponent<Animation>().Play("LockedAnimation");
       }
      }
   }
}

//Новые типы данных для заполнения инвентаря
[System.Serializable]
public struct ItemParams
{
   public string title;
   public int price;
   public Texture image;
}