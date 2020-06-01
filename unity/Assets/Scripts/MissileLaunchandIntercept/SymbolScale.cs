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
        Symbols = GameObject.FindGameObjectsWithTag("Symbol");
    }

    // Update is called once per frame
    void Update()
    {        
        scale = ThalesScale.transform.localScale.x;        
        if(scale<=9000f)
        {            
            foreach (GameObject symbol in Symbols)
            {                
                symbol.SetActive(true);
            }
        }
        else if (scale > 9000f)
        {            
            foreach (GameObject symbol in Symbols)
            {
                symbol.SetActive(false);                
            }
        }        
    }
}
