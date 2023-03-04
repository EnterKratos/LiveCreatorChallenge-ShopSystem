using System;
using System.Collections.Generic;
using EnterKratos.ScriptableObjects;
using UnityEngine;

namespace EnterKratos
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField]
        private List<ShopItem> items = new();

        [SerializeField]
        private int coins;

        [SerializeField]
        private GameEventInt coinsUpdated;

        public int Coins
        {
            get => coins;
            private set
            {
                coins = value;
                coinsUpdated.Raise(value);
            }
        }

        private void Start()
        {
            coinsUpdated.Raise(Coins);
        }

        public bool TryDeductCoins(int value)
        {
            if (Coins < value)
            {
                return false;
            }

            Coins -= value;
            return true;
        }

        public void Add(ShopItem item)
        {
            items.Add(item);
        }
    }
}