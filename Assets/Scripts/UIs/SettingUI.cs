using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : PopUpUI
{
    [SerializeField] ShotCutUI ShotCutUIPrefab;
    protected override void Awake()
    {
        base.Awake();

        buttons["ShotCutButton"].onClick.AddListener(ShotCut);
        buttons["CloseButton"].onClick.AddListener(Close);
    }

    public void ShotCut()
    {
        Manager.UI.ShowPopUpUI(ShotCutUIPrefab);
    }
}