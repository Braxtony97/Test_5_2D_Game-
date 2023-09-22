using System;
using UnityEngine;

namespace Assets.Scripts.GamePlay.ItemScripts
{
    public class ItemPickup : MonoBehaviour
    {
        [SerializeField] private Item _item;
        
        private void Pickup()
        {
            InventoryManager.Instance.AddItem(_item);
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            Pickup();
        }
    }
}
