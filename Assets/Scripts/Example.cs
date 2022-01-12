using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class Example : MonoBehaviour
{
    public AssetReference assetReference1;
    public AssetReference assetReference2;
   
    // Start is called before the first frame update
    void Start()
    {
        assetReference1.InstantiateAsync();
        //assetReference2.InstantiateAsync();
    }

}

