using UnityEngine;

namespace EnterKratos
{
    [CreateAssetMenu]
    public class ShopItem : ScriptableObject
    {
        public new string name;
        public int price;
        public Sprite image;
    }
}