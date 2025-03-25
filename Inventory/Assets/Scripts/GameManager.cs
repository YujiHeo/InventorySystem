using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public static GameManager Instance
    { get { return instance; } }

    public static Character player { get; private set; }

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


    // Start is called before the first frame update
    void Start()
    {
        SetData();
        AddItem(ItemType.Weapon);
        AddItem(ItemType.Armor);
    }

    public void SetData()
    {
        player = new Character();

        player.userName = "허유지";
        player.userlevel = 1;
        player.userMoney = 100000;

        player.userSTR = 40;
        player.userDEF = 30;
        player.userHP = 100;
        player.userCri = 20;

        UIMainMenu.Instance.UpdateUserInfo(player);
        UIStatus.Instance.UpdateUserStatus(player);
    }

    public void AddItem(ItemType item)
    {
        ItemData itemData = Resources.Load<ItemData>(item.ToString());

       
        if(itemData == null)
        {
            Debug.Log("아이템 데이터를 불러오는데 실패하셨습니다 흑흑");
            return;
        }
        
        UIInventory.Instance.AddItem(itemData);
    }
}
