using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI labelText;
    public TextMeshProUGUI stackSizeText;

    public void ClearSlot()
    {
        icon.enabled = false;
        labelText.enabled = false;
        stackSizeText.enabled = false;
    }

    public void DrawSlot(InventoryItem item)
    {
        if(item == null)
        {
            ClearSlot();
            return;
        }

        EnableSlot();

        icon.sprite = item.itemData.icon;
        labelText.text = item.itemData.displayName;
        stackSizeText.text = item.stackSize.ToString();

        //voor volgende keer
        //https://www.youtube.com/watch?v=4-d9Vu3O2jk
        //13:51
    }

    public void EnableSlot()
    {
        icon.enabled = true;
        labelText.enabled = true;
        stackSizeText.enabled = true;
    }
}
