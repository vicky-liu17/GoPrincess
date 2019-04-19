using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);  
       // Debug.Log(Time.timeSinceLevelLoad);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.timeSinceLevelLoad >=2 && Time.timeSinceLevelLoad<=3)
            gameObject.SetActive(false);  
        
       
            
    }
}
