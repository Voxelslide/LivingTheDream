using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerDownHandler, IDropHandler
{

	TargetMessages TM = new TargetMessages();


	[SerializeField]
	string targetName;
	[SerializeField]
	bool isDropTarget;
	[SerializeField]
	public GameObject desiredItem;
	[SerializeField]
	bool givesItem;

	private bool itemGiven = false;


	[SerializeField]
	public GameObject itemToDrop;

	/*
 TARGETS
Dumpster          -Dumpster
Trash bag					-TB
Poster						-Post
Sign							-ESign
Excuse Thumbnail	-EThumb
Excuse This Tall	-ETall
Excuse Talent			-ETalent
Puddle						-Pud
Alley							-All


 */

	public void OnPointerDown(PointerEventData eventData)
	{
		if(givesItem == true && itemGiven == false && isDropTarget == false)
		{
			GiveItem();
		}
		
		string clickMessage = "";
		string clickButtonMessage = "";

		if (targetName == "Dumpster")
		{
			clickMessage = TM.dumpster["Click"];
			clickButtonMessage = TM.dumpster["ClickB"];
		} else if (targetName == "TB") {
			clickMessage = TM.TB["Click"];
			clickButtonMessage = TM.TB["ClickB"];
		} else if (targetName == "Post") {
			clickMessage = TM.Post["Click"];
			clickButtonMessage = TM.Post["ClickB"];
		} else if (targetName == "ESign") {
			clickMessage = TM.ESign["Click"];
			clickButtonMessage = TM.ESign["ClickB"];
		} else if (targetName == "EThumb") {
			clickMessage = TM.EThumb["Click"];
			clickButtonMessage = TM.EThumb["ClickB"];
		}	else if (targetName == "ETall") {
			clickMessage = TM.ETall["Click"];
			clickButtonMessage = TM.ETall["ClickB"];
		}	else if (targetName == "ETalent") {
			clickMessage = TM.ETalent["Click"];
			clickButtonMessage = TM.ETalent["ClickB"];
		} else if (targetName == "Pud")	{
			clickMessage = TM.Pud["Click"];
			clickButtonMessage = TM.Pud["ClickB"];
		} else if (targetName == "All")	{
			clickMessage = TM.All["Click"];
			clickButtonMessage = TM.All["ClickB"];
		}

		Popup.Instance.ShowPopup(clickMessage, clickButtonMessage, () => { });
		
	}


	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null)
		{
			//Debug.Log(dropPopupMessage);

			if(eventData.pointerDrag.GetComponent<Item>().itemName == desiredItem.GetComponent<Item>().itemName)
			{
				if (givesItem && itemGiven == false && isDropTarget)
				{
					Debug.Log("Giving item...");
					GiveItem();
				}

				




			}


			string dropMessage = "";
			string dropButtonMessage = "";

			if (targetName == "Dumpster")
			{
				dropMessage = TM.dumpster["Click"];
				dropButtonMessage = TM.dumpster["ClickB"];
			}
			else if (targetName == "TB")
			{
				dropMessage = TM.TB["Click"];
				dropButtonMessage = TM.TB["ClickB"];
			}
			else if (targetName == "Post")
			{
				dropMessage = TM.Post["Click"];
				dropButtonMessage = TM.Post["ClickB"];
			}
			else if (targetName == "ESign")
			{
				dropMessage = TM.ESign["Click"];
				dropButtonMessage = TM.ESign["ClickB"];
			}
			else if (targetName == "EThumb")
			{
				dropMessage = TM.EThumb["Click"];
				dropButtonMessage = TM.EThumb["ClickB"];
			}
			else if (targetName == "ETall")
			{
				dropMessage = TM.ETall["Click"];
				dropButtonMessage = TM.ETall["ClickB"];
			}
			else if (targetName == "ETalent")
			{
				dropMessage = TM.ETalent["Click"];
				dropButtonMessage = TM.ETalent["ClickB"];
			}
			else if (targetName == "Pud")
			{
				dropMessage = TM.Pud["Click"];
				dropButtonMessage = TM.Pud["ClickB"];
			}
			else if (targetName == "All")
			{
				dropMessage = TM.All["Click"];
				dropButtonMessage = TM.All["ClickB"];
			}

			Popup.Instance.ShowPopup(dropMessage, dropButtonMessage, () => { });

		}
	}



	/*
	 
	 		if (targetName == "Dumpster")
		{
			
		} else if (targetName == "TB") {

		} else if (targetName == "Post") {

		} else if (targetName == "ESign") {

		} else if (targetName == "EThumb") {

		}	else if (targetName == "ETall") {

		}	else if (targetName == "ETalent") {

		} else if (targetName == "Pud")	{

		} else if (targetName == "All")	{

		}
	 
	 */






	private void GiveItem()
	{
		if (itemGiven == false)
		{
			//Get inventory
			Inventory inventory = GameObject.Find("Inventory").GetComponent<Inventory>();

			//instantiate a new item using Item itemToGive
			//The target will be given its specifc item prefab in the editor, no fancy constructor stuff
			GameObject newItem = Instantiate(this.itemToDrop, gameObject.transform.parent);
			newItem.transform.SetAsLastSibling();

			//add it to the inventory
			inventory.AddItem(newItem);
			Debug.Log("Adding " + newItem.name + " to inventory.");
	
			itemGiven = true;
		}
	}



}
