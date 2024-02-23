using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BaseUI : MonoBehaviour
{
    protected Dictionary<string, RectTransform> transform;
    protected Dictionary<string, Button> buttons;
    protected Dictionary<string, TMP_Text> texts;

    protected virtual void Awake()
    {
        Bind();
    }

    private void Bind()
    {
        transform = new Dictionary<string, RectTransform>();
        buttons = new Dictionary<string, Button>();
        texts = new Dictionary<string, TMP_Text>();

        RectTransform[] cjildren = GetComponentsInChildren<RectTransform>();
        foreach (RectTransform child in cjildren)
        {
            string name = child.gameObject.name;

            if (transform.ContainsKey(name))
                continue;

            transform.Add(name, child);


            Button button = child.GetComponent<Button>();
            if (button != null)
            {
                buttons.Add(name, button);
            }

            TMP_Text text = child.GetComponent<TMP_Text>();
            if (text != null)
            {
                texts.Add(name, text);
            }
                
        }
    }
}
