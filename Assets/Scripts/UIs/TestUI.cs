using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : BaseUI
{
    protected override void Awake()
    {
        base.Awake();

        /*texts["Tltle"].text = "Title";
        buttons["NextButton"].onClick.AddListener(Jump);*/
        GetUI<TextMeshProUGUI>("Title").text = "Title";
        GetUI<Button>("NextButton").interactable = false;
        GetUI<Image>("PlayerImage").color = Color.red;
    }
    /*public void Jump()
    {
        Debug.Log("Jump");
    }*/
}