using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{


    public float TimeRemaining;

    public TextMeshProUGUI timeText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(TimeRemaining >= 0)
        {
            TimeRemaining -= Time.deltaTime;

            

            timeText.text = "Time : " + TimeRemaining.ToString();
        }
        else
        {
            if(TimeRemaining < 0)
            {
                TimeRemaining = 0;
            }
            timeText.text = "Time : " + TimeRemaining.ToString();
        }



    }
}
