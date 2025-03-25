using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Health,
    Critical
}

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item")]

public class ItemData : ScriptableObject
{
    public string Name;
    public string Description;

    public ItemType Type;
    public Sprite Icon;
    public int Value;
}
