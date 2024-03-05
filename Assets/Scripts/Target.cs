using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerDownHandler
{

	/*
	 * All targets are click targets, only some are drop targets
	 * 2 types of targets:
	 *	Click target- when this target is clicked on, shows popup and maybe gives an item
	 *	Drop target- when this target is clicked on, shows popup && when item is dropped on this target, shows popup and if the item is the right one, gives an item
	 *	
	 *	Every target shows a popup when it is interacted with, (usually "That won't work" or something clever, not necesarily a game progressing move every time)
	 *	
	*/

	[SerializeField]
	bool isDropTarget;
	[SerializeField]
	bool givesItem;
	[SerializeField]
	Item itemToGive;
	[SerializeField]
	bool destroyOnDrop;
	[SerializeField]
	bool destroyOnClick;

	private bool itemGiven = false;

	[SerializeField]
	string popupMessage;



	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log(popupMessage);
		if(this.givesItem == true && this.itemGiven == false)
		{
			this.GiveItem();
		}

		if (this.destroyOnClick)
		{
			//gameObject.destroy()   or something
		}



	}

	private void GiveItem()
	{
		//instantiate a new item using Item itemToGive

		//add it to the inventory






		itemGiven = true;
	}



}
