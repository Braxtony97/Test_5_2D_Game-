using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item / Create New Item")]
public class Item : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _value;

    public int id => _id;
    public string NameItem => _name;
    public Sprite SpriteItem => _sprite;
    public int Value => _value;


}
