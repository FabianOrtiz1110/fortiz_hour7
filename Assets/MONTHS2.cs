using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MONTHS2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Prints out Months in number format with birth month printing a line.
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log(i);
        }
        Debug.Log("It's my birthday month");
        for (int i = 5; i <= 12; i++)
        {
            Debug.Log(i);
        }

        //Prints number of days in april with birthday printing a different line.
        for (int i = 1; i <= 13; i++)
        {
            Debug.Log(i);
        }

        Debug.Log("It's my birthday");

        for (int i = 15; i <= 30; i++)
        {
            Debug.Log(i);
        }
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
