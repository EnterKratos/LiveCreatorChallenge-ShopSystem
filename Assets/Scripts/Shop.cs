using System.Collections.Generic;
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

        private void Start()
        {
            ClearGrid();

            foreach (var shopItem in items)
            {
                var obj = Instantiate(shopItemPrefab, itemsGrid.transform);
                var itemDisplay = obj.GetComponent<ShopItemDisplay>();
                itemDisplay.SetItem(shopItem);
            }
        }

        private void ClearGrid()
        {
            foreach (Transform child in itemsGrid.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}