using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MenuController : MonoBehaviour, IPointerClickHandler
{
    public Text ClickText;
    public Button EasyButton;
    public Button NormalButton;
    public Button HardButton;
    public Toggle SkipToggle;
    double timer;
    bool clicked;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clicked)
        {
            clicked = true;
            ClickText.gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            EasyButton.onClick.AddListener(() =>
            {
                WorldManager.TowerPerTurn = 7;
                GameObject.Find("World").GetComponent<WorldManager>().StartGame(SkipToggle.isOn);
                transform.parent.gameObject.SetActive(false);
            });
            NormalButton.onClick.AddListener(() =>
            {
                WorldManager.TowerPerTurn = 6;
                GameObject.Find("World").GetComponent<WorldManager>().StartGame(SkipToggle.isOn);
                transform.parent.gameObject.SetActive(false);
            });
            HardButton.onClick.AddListener(() =>
            {
                WorldManager.TowerPerTurn = 5;
                GameObject.Find("World").GetComponent<WorldManager>().StartGame(SkipToggle.isOn);
                transform.parent.gameObject.SetActive(false);
            });
        }
    }

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        if (!clicked)
        {
            timer += Time.deltaTime;
            if (timer > 4)
            {
                timer = 0;
            }
            else if (timer < 2)
            {
                ClickText.color = Color.Lerp(ClickText.color, new Color(0f, 0f, 0f, 0f), 0.035f);
            }
            else
            {
                ClickText.color = Color.Lerp(ClickText.color, Color.black, 0.03f);
            }
        }
    }

}