using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : PopUpUI
{
    [SerializeField] SettingUI SettingUIPrefab;

    protected override void Awake()
    {
        base.Awake();

        buttons["SettingButton"].onClick.AddListener(Setting);
        buttons["CloseButton"].onClick.AddListener(Close);
    }
    public void Setting()
    {
        Manager.UI.ShowPopUpUI(SettingUIPrefab);
    }

}