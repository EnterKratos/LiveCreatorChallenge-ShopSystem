using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EnterKratos
{
    public class ShopItemDisplay : MonoBehaviour
    {
        [SerializeField]
        private Image image;

        [SerializeField]
        private TextMeshProUGUI priceLabel;

        private Shop _shop;
        private ShopItem _item;

        public void SetItem(Shop shop, ShopItem item)
        {
            _shop = shop;
            _item = item;

            image.sprite = item.image;
            priceLabel.text = Helpers.FormatCurrencyValue(item.price);
        }

        public void OnClick()
        {
            _shop.RequestPurchase(_item);
        }
    }
}