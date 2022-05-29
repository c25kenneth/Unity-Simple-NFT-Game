using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    
    public float speed = 500;
    ERC1155BalanceOfExample example;
    public bool shouldRotate;
    Color32 objColor;
    // Start is called before the first frame update
    void Start()
    {

        shouldRotate = example.shouldRotate; 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (shouldRotate) {

            if (Input.GetKey(KeyCode.A))
                transform.Rotate(Vector3.up * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
                transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }

    }
}
