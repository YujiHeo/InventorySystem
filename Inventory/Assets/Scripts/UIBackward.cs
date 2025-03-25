using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBackward : MonoBehaviour
{
    [SerializeField] public GameObject backwrdBtn;

    void Start()
    {
        Button btn = backwrdBtn.GetComponent<Button>();
        btn.onClick.AddListener(UIManager.Instance.Backward);

        //�ϳ��� �����ؼ� ����.........
    }
}
