using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class changetext : MonoBehaviour
{
    public Text accountText; 
    
    void Start()
    {
        accountText.text = PlayerPrefs.GetString("Account"); 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
