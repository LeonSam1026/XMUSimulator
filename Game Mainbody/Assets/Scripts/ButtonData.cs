using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonData : MonoBehaviour
{
    public Button Data_Button;
    public TextMeshProUGUI Data_Text;

    private void Data()
    {
        Data_Button.onClick.AddListener(ButtonOnClick);
    }

    public void ButtonOnClick()
    {
        Data_Text.text = "Here";
    }
}
