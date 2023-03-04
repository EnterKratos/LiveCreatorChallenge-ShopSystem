using EnterKratos.ScriptableObjects;
using UnityEngine.Events;

namespace EnterKratos.GameEventListeners
{
    public class GameEventListenerShopItem : GameEventListener<ShopItem>
    {
        public GameEventShopItem typedEvent;
        public UnityEvent<ShopItem> typedResponse;

        private void Awake()
        {
            Event = typedEvent;
            Response = typedResponse;
        }
    }
}