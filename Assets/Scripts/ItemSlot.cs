using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

	public Item heldItem;
	
	private void Awake()
	{
		transform.SetAsFirstSibling();
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if(eventData.pointerDrag != null)
		{
			if (heldItem == null)
			{
				eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
				heldItem = eventData.pointerDrag.GetComponent<Item>();
				heldItem.itemSlot = this;
			}
			else
			{
				eventData.pointerDrag.GetComponent<Item>().ReturnToPrevLoc();
			}


		}
	}



}
