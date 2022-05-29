using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject cube;
    public bool shouldRotate = false; 
    async void Start()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x88b48f654c30e99bc2e4a1559b4dcf1ad93fa656";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "77717569196177841031337009108397432939784843113369681388984727414693259378689";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0)
        {
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            shouldRotate = true;
        }
        else {
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
