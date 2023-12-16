using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{

    private Test obj;
    TextMeshProUGUI mText;
    void Start()
    {
        obj = GameObject.Find("Player").gameObject.GetComponents<Test>()[0];
        mText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {


        mText.text = Test.score.ToString();
    }
}
