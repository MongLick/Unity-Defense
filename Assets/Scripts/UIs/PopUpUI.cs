using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpUI : BaseUI
{
    public void Close()
    {
        Manager.UI.ClosePopUpUI();
    }
}