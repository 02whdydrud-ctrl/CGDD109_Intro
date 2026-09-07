using UnityEngine;
using TMPro;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    public void OnClick()
    {
        textbox.text = "Button Clicked!";
    }
}