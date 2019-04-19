using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointManager : MonoBehaviour
{
    static public float healthPoint;
    static public int initialHealthPoint = 10;
    public Slider healthBar;
    private const float coef = 0.4f;

    //Text text;

    void Start()
    {
        //text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();
        healthPoint = initialHealthPoint;
        healthBar.value = healthPoint;
    }

    void Update()
    {
        healthPoint -= coef * Time.deltaTime;
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
