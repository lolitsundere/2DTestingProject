using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClosePanelButtonController : MonoBehaviour {

	void Start ()
    {
        transform.GetComponent<Button>().onClick.AddListener(() =>
        {
            transform.parent.gameObject.SetActive(false);
            MouseMoveInHandler.MouseIn = false;
        });
	}
	
}
