using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{

    [SerializeField] private GameObject _slotPrefab;
    [SerializeField] private List<InventorySlot> _inventorySlots = new List<InventorySlot>(6);

    
    void ResetInventory()
    {
        foreach(Transform childTransform in transform)
        {
            Destroy(childTransform.gameObject);
        }

        _inventorySlots = new List<InventorySlot>(6);
    }
    
    void DrawInventory(List<InventoryItem> inventory)
    {
        ResetInventory();

        for(int i = 0; i < _inventorySlots.Capacity; i++)
        {
            CreateInventorySlot();
        }

        for (int i = 0; i < inventory.Count; i++)
        {
            _inventorySlots[i].DrawSlot(inventory[i]);
        }
    }

    void CreateInventorySlot()
    {
        GameObject newSlot = Instantiate(_slotPrefab);
        newSlot.transform.SetParent(transform, false);

        InventorySlot newSlotComponent = newSlot.GetComponent<InventorySlot>();
        newSlotComponent.ClearSlot();

        _inventorySlots.Add(newSlotComponent);
    }
}