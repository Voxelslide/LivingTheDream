using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


//Drag and drop functionality using tutorial https://www.youtube.com/watch?v=BGr-7GZJNXg
public class Item : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler    //Drop most likely won't be a part of the item anymore
{
	[SerializeField]
	public string itemName;
	[SerializeField]
	private Sprite image;

	public ItemSlot itemSlot;

	public RectTransform rectTransform;
	public CanvasGroup canvasGroup;

	private Vector3 previousLocation;


	




	public void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log("OnPointerDown");
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		canvasGroup.alpha = 0.6f;
		canvasGroup.blocksRaycasts = false;
		previousLocation = gameObject.transform.position;
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("EndDrag");
		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;
		this.ReturnToPrevLoc();
	}



	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if (eventData.pointerDrag != null)
		{
				//eventData.pointerDrag.GetComponent<Item>().ReturnToPrevLoc();
		}
	}

	public void ReturnToPrevLoc()
	{
		gameObject.transform.position = previousLocation;
		
		Debug.Log(itemName + " previousLocation  == " + previousLocation);
	}




}
