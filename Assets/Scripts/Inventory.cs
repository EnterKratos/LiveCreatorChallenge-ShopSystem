using System;
using System.Collections.Generic;
using EnterKratos.ScriptableObjects;
using UnityEngine;

namespace EnterKratos
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField]
        private List<ShopItem> items;

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
            coinsUpdated.Raise(coins);
        }
    }
}