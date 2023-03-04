using UnityEngine;

namespace EnterKratos
{
    [CreateAssetMenu]
    public class ShopItem : ScriptableObject
    {
        public new string name;
        public double price;
        public Sprite image;
    }
}