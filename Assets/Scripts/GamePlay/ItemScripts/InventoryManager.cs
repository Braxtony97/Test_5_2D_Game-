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

        [SerializeField] private Dictionary<Item, int> _itemsDictionary = new Dictionary<Item, int>();

        [SerializeField] private Toggle _toggleEnableRemoveItem;

        [SerializeField] private GameObject _itemPrefab; // 2D префаб объекта
        [SerializeField] private Transform _itemContentInventory; // где наш объект будет находится

        private void Awake()        
        {
            Instance = this;
        }

        public void AddItem (Item item)
        {
            if (_itemsDictionary.ContainsKey(item))
            {
                _itemsDictionary[item]++;
                item.ItemQuantity++;
            }
            else
            {
                _itemsDictionary[item] = 1;
                item.ItemQuantity = 1;

            }
        }

        public void RemoveItem(Item item)
        {
            if (_itemsDictionary.ContainsKey(item))
            {
                _itemsDictionary[item]--;
                item.ItemQuantity--;
                if (item.ItemQuantity <= 0)
                {
                    _itemsDictionary.Remove(item);
                }
            }
        }

        public void ListItems()
        {
            foreach (Transform item in _itemContentInventory)
            {
                Destroy(item.gameObject);
            }

            foreach (var item in _itemsDictionary)
            {
                GameObject objectItem = Instantiate(_itemPrefab, _itemContentInventory);
                var itemName = objectItem.transform.Find("ItemText").GetComponent<TextMeshProUGUI>();
                var itemCount = objectItem.transform.Find("ItemCountButton/ItemCountButtonText").GetComponent<TextMeshProUGUI>();
                var itemIcon = objectItem.transform.Find("ItemIcon").GetComponent<Image>();

                itemIcon.sprite = item.Key.SpriteItem;
                itemName.text = item.Key.NameItem;
                itemCount.text = item.Key.ItemQuantity.ToString();
            }
        }

        public void EnableRemoveItem()
        {
            if (_toggleEnableRemoveItem.isOn)
            {
                foreach (Transform item in _itemContentInventory)
                {
                    item.Find("ItemRemoveButton").gameObject.SetActive(true);
                }
            }
            else
            {
                foreach (Transform item in _itemContentInventory)
                {
                    item.Find("ItemRemoveButton").gameObject.SetActive(false);
                }
            }
        }
    }
}
