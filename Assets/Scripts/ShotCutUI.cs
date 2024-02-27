using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCutUI : PopUpUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["CloseButton"].onClick.AddListener(Close);
    }
}