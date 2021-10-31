using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeNameBase : MonoBehaviour
{
    [Header("Refencess")]
    public TextMeshProUGUI uiTextName;
    public TMP_InputField uiInputField;
    public GameObject changeInputName;

    public Player player;

    private string playerName;



    public void ChangeName()
    {
        playerName = uiInputField.text;
        uiTextName.text = uiInputField.text;
        changeInputName.SetActive(false);
        player.SetName(playerName);
        
    }

}
