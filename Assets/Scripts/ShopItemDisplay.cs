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

        public void SetItem(ShopItem item)
        {
            image.sprite = item.image;
            priceLabel.text = Helpers.FormatCurrencyValue(item.price);
        }
    }
}