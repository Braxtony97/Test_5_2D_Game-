using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GamePlay.ItemScripts
{
    public class InventoryManager : MonoBehaviour
    {
        public static InventoryManager Instance;
        [SerializeField] private List<Item> _items = new List<Item>();

        [SerializeField] private GameObject _itemPrefab; // 2D префаб объекта
        [SerializeField] private Transform _itemContentInventory; // где наш объект будет находится

        private void Awake()        
        {
            Instance = this;
        }

        public void AddItem (Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        public void ListItems()
        {
            foreach (Transform item in _itemContentInventory)
            {
                Destroy(item.gameObject);
            }

            foreach (var item in _items)
            {
                GameObject objectItem = Instantiate(_itemPrefab, _itemContentInventory);
                var itemName = objectItem.transform.Find("ItemText").GetComponent<TextMeshProUGUI>();
                var itemIcon = objectItem.transform.Find("ItemIcon").GetComponent<Image>();

                itemIcon.sprite = item.SpriteItem;
                itemName.text = item.NameItem;
            }
        }
    }
}
