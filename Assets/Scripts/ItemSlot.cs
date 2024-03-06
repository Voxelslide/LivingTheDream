using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

	public GameObject heldItem;
	
	public void AddItem(GameObject newItem)
	{
		heldItem = newItem;
		heldItem.GetComponent<Item>().itemSlot = this;
		heldItem.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
	}





	private void Awake()
	{
		transform.SetAsFirstSibling();
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		
		
		//Getting refactored, you can't drag and drop items into the inventory, they'll immediately get added on creation.
		/*
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
		*/
	}



}
