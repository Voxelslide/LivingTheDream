using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Target : MonoBehaviour, IPointerDownHandler, IDropHandler
{
	[SerializeField]
	string targetName;
	[SerializeField]
	bool givesItem;
	[SerializeField]
	bool isDropTarget;
	[SerializeField]
	public GameObject desiredItem;

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

	private TargetMessages TM;

	void Awake()
	{
		TM = GameObject.Find("GameManager").GetComponent<TargetMessages>();
	}



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
		Debug.Log("Click Message: " + clickMessage);
		Popup.Instance.ShowPopup(clickMessage, clickButtonMessage, () => { });
		
	}


	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null)
		{
			//Debug.Log(dropPopupMessage);

			if(givesItem && isDropTarget && itemGiven == false && eventData.pointerDrag.GetComponent<Item>().itemName == desiredItem.GetComponent<Item>().itemName )
			{
				Debug.Log("Giving item...");
				GiveItem();
			}
			string itemName = eventData.pointerDrag.GetComponent<Item>().itemName;

			string dropMessage = "";
			string dropButtonMessage = "";

			if (targetName == "Dumpster")
			{
				dropMessage = TM.dumpster[itemName];
				dropButtonMessage = TM.dumpster[itemName + "B"];
			}
			else if (targetName == "TB")
			{
				dropMessage = TM.TB[itemName];
				dropButtonMessage = TM.TB[itemName + "B"];
			}
			else if (targetName == "Post")
			{
				dropMessage = TM.Post[itemName];
				dropButtonMessage = TM.Post[itemName + "B"];
			}
			else if (targetName == "ESign")
			{
				dropMessage = TM.ESign[itemName];
				dropButtonMessage = TM.ESign[itemName + "B"];
			}
			else if (targetName == "EThumb")
			{
				dropMessage = TM.EThumb[itemName];
				dropButtonMessage = TM.EThumb[itemName + "B"];
			}
			else if (targetName == "ETall")
			{
				dropMessage = TM.ETall[itemName];
				dropButtonMessage = TM.ETall[itemName + "B"];
			}
			else if (targetName == "ETalent")
			{
				dropMessage = TM.ETalent[itemName];
				dropButtonMessage = TM.ETalent[itemName + "B"];
			}
			else if (targetName == "Pud")
			{
				dropMessage = TM.Pud[itemName];
				dropButtonMessage = TM.Pud[itemName + "B"];
			}
			else if (targetName == "All")
			{
				dropMessage = TM.All[itemName];
				dropButtonMessage = TM.All[itemName + "B"];
			}

			if(targetName == "All" && itemName == "Con")
			{

			}
			else
			{
				Popup.Instance.ShowPopup(dropMessage, dropButtonMessage, () => { });

			}

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
