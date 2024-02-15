using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class WorldTimeScript : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    float SecondsTime;
    float MinutesTime;
    float HoursTime;
 
    void Update()
    {
      SecondsTime+=Time.deltaTime*5;
      if(SecondsTime >= 60)
      {
        SecondsTime = 0;
        MinutesTime += 1;
      }
      if(MinutesTime >= 60)
      {
        MinutesTime = 0;
        HoursTime += 1;
      }
      if(HoursTime >= 24)
      {
        HoursTime = 0;
      }
      Timer.text = HoursTime.ToString() + ":" + MinutesTime.ToString();
    }
}
