using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Item[] items;
    public void Equip(int arrayNumber)
    {
        var data = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        GameObject.Instantiate(data.items[arrayNumber].prefab, data.items[arrayNumber].location);
    }
}
