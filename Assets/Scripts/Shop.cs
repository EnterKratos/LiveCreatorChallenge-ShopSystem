using System.Collections.Generic;
using EnterKratos.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace EnterKratos
{
    public class Shop : MonoBehaviour
    {
        [SerializeField]
        private GridLayoutGroup itemsGrid;

        [SerializeField]
        private GameObject shopItemPrefab;

        [SerializeField]
        private List<ShopItem> items;

        [SerializeField]
        private Inventory playerInventory;

        [SerializeField]
        private GameEventShopItem itemPurchasedEvent;

        [SerializeField]
        private GameEventShopItem failedToPurchaseItem;

        private void Start()
        {
            ClearGrid();

            foreach (var shopItem in items)
            {
                var obj = Instantiate(shopItemPrefab, itemsGrid.transform);
                var itemDisplay = obj.GetComponent<ShopItemDisplay>();
                itemDisplay.SetItem(this, shopItem);
            }
        }

        private void ClearGrid()
        {
            foreach (Transform child in itemsGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }

        public void RequestPurchase(ShopItem item)
        {
            if (playerInventory.TryDeductCoins(item.price))
            {
                itemPurchasedEvent.Raise(item);
                playerInventory.Add(item);
            }
            else
            {
                failedToPurchaseItem.Raise(item);
            }
        }
    }
}