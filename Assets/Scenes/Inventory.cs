using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private int _invSize;
    GameObject[] inventoryArray;

    public Inventory(int invSizeInt)
    {
        _invSize = invSizeInt;

        inventoryArray = new GameObject[_invSize];
    }
    
    public void AddItem(GameObject item, int slot)
    {
        inventoryArray[slot] = item;
    }
    public GameObject getItem(int slot)
    {
        return inventoryArray[slot];
    }

    public void populateInv()
    {
        Random rng = new Random();
        
        for(int i = 0; i < inventoryArray.Length(); i++)
        {
            AddItem(ItemEnum[rng.Next(inventoryArray.Length())], i);
        }
    }
}
