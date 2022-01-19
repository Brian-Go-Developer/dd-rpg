using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory;

public class ChestInventory : MonoBehaviour
{
    private int _invSize = 6;
    // Start is called before the first frame update
    void Start()
    {
        Inventory thisInventory = new Inventory(_invSize);
        //thisInventory.populateInv();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
