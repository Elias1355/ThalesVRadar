using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolScale : MonoBehaviour
{
    public GameObject ThalesScale;
    public GameObject[] Symbols;
    private float scale;
    private float symbolScale;
    // Start is called before the first frame update
    void Start()
    {
        symbolScale = 1f;
        Symbols = GameObject.FindGameObjectsWithTag("Symbol");
    }

    // Update is called once per frame
    void Update()
    {        
        scale = ThalesScale.transform.localScale.x;
        Debug.Log(scale);
        Debug.Log("SymbolsScale :" + symbolScale);
        if(scale<300f)
        {            
            foreach (GameObject symbol in Symbols)
            {                
                symbol.SetActive(true);
            }
            symbolScale = scale;
        }
        else if (scale >= 300)
        {
            symbolScale = 1f;
            foreach (GameObject symbol in Symbols)
            {
                symbol.SetActive(false);                
            }
        }        
    }

    private Vector3 symbolScaleUp(GameObject symbol)
    {
        Vector3 scaledSymbol;
        scaledSymbol = symbol.transform.localScale*symbolScale;
        return scaledSymbol;
    }
}
