using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : MonoBehaviour
{
    public static Character Instance { get; private set; }

    [HideInInspector]
    public string userName;
    [HideInInspector]
    public int userlevel;
    [HideInInspector]
    public int userMoney;

    [HideInInspector]
    public int userSTR;
    [HideInInspector]
    public int userDEF;
    [HideInInspector]
    public int userHP;
    [HideInInspector]
    public int userCri;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}
