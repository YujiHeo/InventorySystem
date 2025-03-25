using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class UIInventory : MonoBehaviour
{
    static UIInventory instance;

    public static UIInventory Instance
    { get { return instance; } }


    [SerializeField] public Button inventoryBtn;
    [SerializeField] public GameObject inventoryWindow;

    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParent;

    [SerializeField] private TextMeshProUGUI slotCounts;

    private List<UISlot> slotList = new List<UISlot>();

    private int slotIndex = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        Button btn = inventoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(UIManager.Instance.OpenInventory);

        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        int slotCount = 10;
        slotCounts.text = slotCount.ToString();

        for (int i = 0; i < slotCount; i++) // 10¹ø ¹Ýº¹µÊ
        {
            Debug.Log($"½½·Ô »ý¼º Áß: {i}");
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            slotList.Add(newSlot);
        }
    }

    public void AddItem(ItemData itemData)
    {
        slotList[slotIndex].SetItem(itemData);
        slotIndex++;
    }
}
