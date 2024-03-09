using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//Popup functionality using tutorial https://www.youtube.com/watch?v=msCGC22vKQM
public class Popup : MonoBehaviour
{
  private TextMeshProUGUI popupTMP;
  private Button btn;
  private TextMeshProUGUI btnTMP;

  // Update is called once per frame
  void Awake()
  {
    popupTMP = transform.Find("Text").GetComponent<TextMeshProUGUI>();
    btn = transform.Find("Button").GetComponent<Button>();
    btnTMP = btn.transform.Find("Text").GetComponent<TextMeshProUGUI>();


    ShowPopup("This is an example of what a popup can do. \n This tutorial sure was helpful.", "WOW!", () =>
      {
        Debug.Log("BUTTON PRESSED");
      });
      
    
  }

  public void ShowPopup(string popupText, string buttonText, Action btnAction)
	{
    //btn Action is the function to call when the button is pressed
    popupTMP.text = popupText;
    btnTMP.text = buttonText;
    btn.onClick.AddListener(new UnityEngine.Events.UnityAction(btnAction));
	}
	


}
