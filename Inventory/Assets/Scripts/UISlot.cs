using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private Image itemImage;

    private ItemData itemData;

    public void SetItem(ItemData item)
    {
        itemData = item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (itemData != null)
        {
            itemNameText.text = itemData.Name;
            itemImage.sprite = itemData.Icon;
        }

        else
        {
            itemNameText.text = "";
            itemImage.sprite = null;
        }
    }
}
