using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public bool canPickUp;
    public string lookAtText;
    public string pickUpText;
    public List<int> requiredItemIDs = new List<int>();
    public GameObject targetNavPoint;
    public Sprite inventorySprite;
}
