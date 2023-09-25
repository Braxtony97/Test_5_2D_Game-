using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item / Create New Item")]
public class Item : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _value;
    [SerializeField] private int _itemQuantity;
    [SerializeField] private GameObject _gameObject;

    public int id => _id;
    public string NameItem => _name;
    public Sprite SpriteItem => _sprite;
    public int Value => _value;
    public int ItemQuantity
    {
        get => _itemQuantity;
        set => _itemQuantity = value;
    }
    public GameObject GameObject => _gameObject;


}
