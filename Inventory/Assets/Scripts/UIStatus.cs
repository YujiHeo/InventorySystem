using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class UIStatus : MonoBehaviour
{
    static UIStatus instance;

    public static UIStatus Instance {  get { return instance; } }


    [SerializeField] public Button stateBtn;
    [SerializeField] public GameObject statusWindow;

    [SerializeField] public TextMeshProUGUI str;
    [SerializeField] public TextMeshProUGUI def;
    [SerializeField] public TextMeshProUGUI hp;
    [SerializeField] public TextMeshProUGUI cri;

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
        Button btn = stateBtn.GetComponent<Button>();
        btn.onClick.AddListener(UIManager.Instance.OpenStatus);


        //UpdateUserStatus(player);
    }

    public void UpdateUserStatus(Character player)
    {
        str.text = $"{GameManager.player.userSTR}";
        def.text = $"{GameManager.player.userDEF}";
        hp.text = $"{GameManager.player.userHP}";
        cri.text = $"{GameManager.player.userCri}";

    }
}
