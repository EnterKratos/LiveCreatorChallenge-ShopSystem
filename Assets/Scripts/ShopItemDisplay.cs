using UnityEngine;
using UnityEngine.UI;

namespace EnterKratos
{
    public class ShopItemDisplay : MonoBehaviour
    {
        [SerializeField]
        private Image image;

        private ShopItem _item;

        public void SetItem(ShopItem item)
        {
            _item = item;
            image.sprite = item.image;
            Debug.Log(item.name);
        }
    }
}