using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highScore : MonoBehaviour
{

    TextMeshProUGUI mText;


    void Start()
    {
        
        mText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        mText.text = "Your score is " + Test.score.ToString();
    }
}
