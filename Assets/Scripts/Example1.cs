using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class Example1 : MonoBehaviour
{
    public AssetReference assetReference;
    // Start is called before the first frame update
    void Start()
    {
        assetReference.InstantiateAsync();
    }
    
}
