using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject Status;
    public GameObject Warning;
    private TextMeshPro warningTxt;
    private TextMeshPro statusTxt;
    // Start is called before the first frame update
    void Start()
    {
        Warning = GameObject.Find("Warning");
        Status = GameObject.Find("Status");
        warningTxt = Warning.GetComponent<TextMeshPro>();
        statusTxt = Status.GetComponent<TextMeshPro>();
        Warning.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    IEnumerator warning_On()
    {
        
        return null;
    }

    public void statusUpdate(Text text)
    {

    }
}
