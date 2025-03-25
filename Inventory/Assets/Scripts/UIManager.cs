using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance 
        { get { return instance; } }

    [SerializeField] private UIInventory uIInventory;
    [SerializeField] private UIStatus uIStatus;
    [SerializeField] private UIMainMenu uIMainMenu;
    [SerializeField] private UIBackward uIBackward;


    [Header("스테이터스, 인벤토리 진입 버튼")]
    [SerializeField] GameObject MainBtn;


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

    public void OpenMainMenu()
    {

    }

    public void OpenStatus()
    {
        MainBtn.SetActive(false);
        uIStatus.statusWindow.SetActive(true);
        uIBackward.backwrdBtn.SetActive(true);
    }

    public void OpenInventory()
    {
        MainBtn.SetActive(false);
        uIInventory.inventoryWindow.SetActive(true);
        uIBackward.backwrdBtn.SetActive(true);
    }

    public void Backward()
    {
        uIBackward.backwrdBtn.SetActive(false);
        uIStatus.statusWindow.SetActive(false);
        uIInventory.inventoryWindow.SetActive(false);

        MainBtn.SetActive(true);
    }
}
