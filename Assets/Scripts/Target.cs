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
	GameObject desiredItem;
	[SerializeField]
	bool givesItem;
	[SerializeField]
	bool destroyOnDrop;
	[SerializeField]
	bool destroyOnClick;

	private bool itemGiven = false;

	[SerializeField]
	string popupMessage;

	[SerializeField]
	public GameObject itemToDrop;

	public void OnPointerDown(PointerEventData eventData)
	{
		Debug.Log(popupMessage);
		if(givesItem == true && itemGiven == false && isDropTarget == false)
		{
			GiveItem();
		}

		if (destroyOnClick)
		{
			//gameObject.destroy()   or something
		}



	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log("OnDrop");
		if (eventData.pointerDrag != null)
		{
			Debug.Log(popupMessage);
			if (givesItem == true && itemGiven == false)
			{
				if(eventData.pointerDrag == desiredItem)
				{
					GiveItem();
				}
			}

			/*
			if (destroyOnDrop)
			{
				gameObject.destroy()   or something
			}
			*/
		
		
		}
	}




	private void GiveItem()
	{
		if (itemGiven == false)
		{
			//Get inventory
			Inventory inventory = GameObject.Find("Inventory").GetComponent<Inventory>();

			//Get canvas
			


			//instantiate a new item using Item itemToGive
			//The target will be given its specifc item prefab in the editor, no fancy constructor stuff
			GameObject newItem = Instantiate(itemToDrop, gameObject.transform.parent);
			newItem.transform.SetAsLastSibling();

			//add it to the inventory
			inventory.AddItem(newItem);
	
			itemGiven = true;
		}
	}



}
