using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RecoverButtonController : MonoBehaviour {

	void Start ()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            int re = new System.Random().Next(10) + 1;
            if (WorldManager.Health + re > 100)
            {
                WorldManager.Health = 100;
            }
            else
            {
                WorldManager.Health += re;
            }
            WorldManager.PlayerGold -= 500;
        });
	}
	
	void Update ()
    {
        if (WorldManager.Health < 100 && WorldManager.PlayerGold >= 500)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }
}
