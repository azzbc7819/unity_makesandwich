using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end_ui : MonoBehaviour
{
    public Text info;
    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        info.text = "Your Score is " + whatscore.score.ToString();
        info.text += "\nDo you want to play one more \npress \"R\"";
    }
}
