using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
  [SerializeField]
  public ItemSlot[] inventorySlots;

  [SerializeField]
  public List<GameObject> inventory;

  //I can either give the inventory its slots w/ the child references, or set it in editor

    // Start is called before the first frame update
    void Start()
    {
         
    }





    
  public void AddItem(GameObject itemToAdd)
	{
    Debug.Log("Recieving " + itemToAdd.name);

		if (!inventory.Contains<GameObject>(itemToAdd))
		{
      inventory.Add(itemToAdd);
      inventorySlots[inventory.Count-1].AddItem(itemToAdd);
		}

	}



}
