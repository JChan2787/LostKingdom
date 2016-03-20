using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	// This strut contains the ID for the item, as well as the
	// quantity of said item.
	public struct ItemSlot
	{
		public int itemID;
		public int itemQty;

		public ItemSlot(string item_ID, int item_Qty)
		{
			item_ID = itemID;
			item_Qty = itemQty;
		}
	}

	#region Data Members

	private List<ItemSlot> itemList;	// Contains a list of all the items a character has.
	private int maxCarry;				// The max number of base items a character can carry at one time.

	#endregion

	#region Setters & Getters

	// Gets and sets the item list
	public List<ItemSlot> Item_List {
		get {return itemList;}
		set {itemList = value;}
	}

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	void Start () {
		itemList = new List<string>();

		maxCarry = 10;
	}

	// Update is called once per frame
	void Update () {

	}

	#endregion

	#region Public Methods

	// Allows the user to inspect a specific item.
	public void InspectItem(int index) 
	{
		
		
	}

	// Checks to see if inventory is full,
	// if not, the item is added, if so, 
	// inventory is full and item cannot be added.
	public bool AddItem (BaseItem item) {
		bool canAddItem = false;

		// Checks if the inventory max carry is reached.
		if (maxCarry < 10) 
		{
			canAddItem = true;
		
			// Checks if the item is stackable.
			if (item.Is_Stackable) 
			{
				// Checks if the item exists in the character's inventory.
				if (itemList.Exists (o => o.itemID == item.Item_Name)) 
				{
					// Obtains the item index.
					int tempIndex = itemList.FindIndex (o => o.itemID == item.Item_Name);

					// Updates the inventory quantity.
					itemList [tempIndex].itemQty++;

				} 
				else
				{
					ItemSlot temp = new ItemSlot (item.Item_Name, 0);
					itemList.Add (temp); 
				}
			} 
			else 
			{
				//Repeat of Line 84 & 85
				//Possible refactor?
				ItemSlot temp = new ItemSlot (item.Item_Name, 0);
				itemList.Add (temp);
			}

			// Since the item has been "picked up" by the player, 
			// The item GameObject is destroyed from the game scene.
			Destroy (item.gameObject);
		}
		return canAddItem;
	}

	// Removes a specific item from the character's inventory.
	public void RemoveItem(int index) {
		itemList.RemoveAt (index);
	}

	// Allows a character to equip a specific item.
	public void EquipItem(int index) {
		GameObject equipItem;

		// The "tbd" will be changed, as well as the transform.
		equipItem = Instantiate(Resources.Load("tbd"), gameObject.transform.position, Quaternion.identity)as GameObject; 
	}

	// Allows a character to use a specific item.
	public void UseItem(int index) {

	}

	private void TransformBaseItem() {
	
	}

	// Checks if the number of items in the inventory
	// has exceeded the max quantity of the inventory.
	private bool CheckMaxCarry() {
		bool isAtMaxCarry = false;

		return isAtMaxCarry;
	}

	#endregion

	#region Private Methods

	#endregion

	#region Helper Classes/Structs


	#endregion
}
