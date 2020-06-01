using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolScale : MonoBehaviour
{
    public GameObject ThalesScale;
    public GameObject[] Symbols;
    private float scale;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(scale);
        scale = ThalesScale.transform.localScale.x;
        Symbols = GameObject.FindGameObjectsWithTag("Symbol");
        foreach (GameObject symbol in Symbols)
        {
            if(scale>1000)
            {
                symbol.SetActive(false);
            }
            else if(scale<1000)
            {
                symbol.SetActive(true);
            }
        }
    }
}
