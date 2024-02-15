using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGstat : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    [System.Serializable]
    public struct Characteristic
    {
        public int HealthPoints;
        public int ActionPoints;
        static int SleepPoints = 100;
    }
}
