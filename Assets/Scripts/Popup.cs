using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//Popup functionality using tutorial https://www.youtube.com/watch?v=msCGC22vKQM
public class Popup : MonoBehaviour
{
  public static Popup Instance { get; private set; }

  private RectTransform bgRectTransform;
  private TextMeshProUGUI popupTMP;
  private Button btn;
  private TextMeshProUGUI btnTMP;
  private RectTransform btnRectTransform;

  private Vector2 bgTextPadding = new Vector2(10, 10);
  private Vector2 btnTextPadding = new Vector2(40, 5);

  // Update is called once per frame
  void Awake()
  {
    Instance = this;
    transform.SetAsLastSibling();
    bgRectTransform = transform.Find("BG").GetComponent<RectTransform>();
    popupTMP = transform.Find("Text").GetComponent<TextMeshProUGUI>();
    btn = transform.Find("Button").GetComponent<Button>();
    btnTMP = btn.transform.Find("Text").GetComponent<TextMeshProUGUI>();
    btnRectTransform = btn.GetComponent<RectTransform>();


    ShowPopup("Looking around, you can't grasp onto anything that makes sense.", "Huh...", () =>
      {
        Debug.Log("BUTTON PRESSED");
      });
      
    
  }

  public void ShowPopup(string popupText, string buttonText, Action btnAction)
	{
    //btn Action is the function to call when the button is pressed
    
    Show();
    
    popupTMP.SetText(popupText);
    btnTMP.SetText(buttonText);
    popupTMP.ForceMeshUpdate();
    btnTMP.ForceMeshUpdate();

    Vector2 popUpTextSize = popupTMP.GetRenderedValues(false);
    bgRectTransform.sizeDelta = popUpTextSize + bgTextPadding;
    Vector2 btnTextSize = btnTMP.GetRenderedValues(false);
    btnRectTransform.sizeDelta = btnTextSize + btnTextPadding;



    btn.onClick.AddListener(() =>
    {
      Hide();
      btnAction();
    });
      
	}


  public void Show()
  {
    gameObject.SetActive(true);
    transform.SetAsLastSibling();
  }

  public void Hide()
	{
    gameObject.SetActive(false);
	}




}
