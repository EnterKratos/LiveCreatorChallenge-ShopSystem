using TMPro;
using UnityEngine;

namespace EnterKratos
{
    public class TextUpdater : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI textField;

        public void SetText(int value) => textField.text = value.ToString();
    }
}