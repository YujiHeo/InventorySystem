using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class UIMainMenu : MonoBehaviour
{
    static UIMainMenu instance;

    public static UIMainMenu Instance
    {  get { return instance; } }

    [SerializeField] public TextMeshProUGUI name;
    [SerializeField] public TextMeshProUGUI level;
    [SerializeField] public TextMeshProUGUI money;

    //private Character player;

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
        //UpdateUserInfo(player);
    }

public void UpdateUserInfo(Character player)
    {
        name.text = $"{GameManager.player.userName}";
        level.text = $"{GameManager.player.userlevel}";
        money.text = $"{GameManager.player.userMoney}";
    }
}
