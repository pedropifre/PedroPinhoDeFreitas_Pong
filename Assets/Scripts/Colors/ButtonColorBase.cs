using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Image))]
public class ButtonColorBase : MonoBehaviour
{
    public Color color;

    [Header("References")]
    public Image uiImage;
    public TextMeshProUGUI uiTextColor;
    public Player myPlayer;

    private void OnValidate()
    {
        uiImage = GetComponent<Image>();
    }
    void Start()
    {
        uiImage.color = color;
        //mesma coisa do que fazer na ui do unity onClick
        //GetComponent<Button>().onClick.AddListener(OnClick);

    }

    public void OnClick()
    {
        myPlayer.ChangeColor(color);
        uiTextColor.GetComponent<TextMeshProUGUI>().color = color;
    }
}
