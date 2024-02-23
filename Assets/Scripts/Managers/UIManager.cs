using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    [SerializeField] EventSystem eventSystemPrefab;

    private Stack<PopUpUI> popUpStack;

    private void Awake()
    {
        EnsureEventSystem();
    }

    public void EnsureEventSystem()
    {
        EventSystem eventSystem = FindObjectOfType<EventSystem>();
        if(eventSystem == null)
        {
            Instantiate(eventSystemPrefab);
        }
    }

    public T ShowPopUpUI<T>(T popUpUI) where T : PopUpUI
    {
        if(popUpStack.Count > 0)
        {
            PopUpUI prevUI = popUpStack.Peek();
            prevUI.gameObject.SetActive(false);
        }

        T instance = Instantiate(popUpUI);
        popUpStack.Push(popUpUI);
        Time.timeScale = 0f;

        return popUpUI;
    }

    public void ClosePopUpUI()
    {
        PopUpUI curUI = popUpStack.Pop();
        Destroy(curUI.gameObject);

        if(popUpStack.Count > 0)
        {
            PopUpUI prevUI = popUpStack.Peek();
            prevUI.gameObject.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
