using TMPro;
using UnityEngine;

namespace EnterKratos
{
    public class TextUpdater : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI textField;

        [SerializeField]
        private bool isCurrency;

        public void SetText(int value) =>
            textField.text = isCurrency ?
                Helpers.FormatCurrencyValue(value) :
                value.ToString();
    }
}