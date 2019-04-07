using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointManager : MonoBehaviour
{
    public static int healthPoint;
    public static int initialHealthPoint = 10;
    public Slider healthBar;
   

    //Text text;

    void Start()
    {
        //text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();
        healthPoint = initialHealthPoint;
        healthBar.value = initialHealthPoint;
    }

    void Update()
    {
        if (healthPoint < 0)
        {
            gameObject.SetActive(false);
        }
        //text.text = "" + healthPoint;
        healthBar.value = healthPoint;
    }

    public static void AddHealthPoints(int healthPointsToAdd)
    {
        healthPoint = healthPoint + healthPointsToAdd;
    }
    public static void DedcuteHealthPoint (int healthPointsToDeduct)
    {
        healthPoint = healthPoint - healthPointsToDeduct;
    }


}
