using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseUI : MonoBehaviour
{
    protected Dictionary<string, RectTransform> transforms;
    protected Dictionary<string, Button> buttons;
    protected Dictionary<string, TMP_Text> texts;

    //protected Dictionary<string, Component> components;


    protected virtual void Awake()
    {
        // Debug.Log("Binding");
        Bind();
    }

    private void Bind()
    {
        transforms = new Dictionary<string, RectTransform>();
        buttons = new Dictionary<string, Button>();
        texts = new Dictionary<string, TMP_Text>();

        RectTransform[] children = GetComponentsInChildren<RectTransform>();
        foreach (RectTransform child in children)
        {
            string name = child.gameObject.name;

            if (transforms.ContainsKey(name)) continue;

            transforms.Add(name, child);

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

        /*components = new Dictionary<string, Component>();
        Component[] children2 = GetComponentsInChildren<Component>();
        foreach (Component child in children2)
        {
            string name = $"{child.gameObject.name}_{child.GetType().Name}";
            components.Add(name, child);
        }*/
    }

    /*public T GetUI<T>(string name) where T : Component
    {
        return components[$"{name}_{typeof(T).Name}"] as T;
    }*/
}