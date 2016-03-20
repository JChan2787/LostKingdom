using UnityEngine;
using System.Collections;

public enum ItemType {
	EQUIPMENT,
	CONSUMABLE,
	NON_CONSUMABLE
};

public abstract class BaseItem : MonoBehaviour {
	#region Data Members

	protected int itemID;					// The item's ID number
	protected string itemName;				// The item name
	protected string itemDescription;		// The item's description
	public Sprite itemIcon;					// The sprite for the item icon
	protected int price;					// The price of the item
	protected ItemType type;				// The type of item
	protected bool isStackable;				// Whether or not the item is stackable

	#endregion

	/*
	public void Display() {

	}
	*/

	#region Setters & Getters

	// Gets and sets the item ID
	public string Item_ID {
		get {return itemID;}
		set {itemID = value;}
	}

	// Gets and sets the item name
	public string Item_Name {
		get {return itemName;}
		set {itemName = value;}
	}

	// Gets and sets the item description
	public string Item_Description {
		get {return itemDescription;}
		set {itemDescription = value;}
	}

	// Gets and sets the item icon
	public Sprite Item_Sprite {
		get {return itemIcon;}
		set {itemIcon = value;}
	}

	// Gets and sets the item price
	public int Item_Price {
		get {return price;}
		set {price = value;}
	}

	// Gets and sets the item type
	public ItemType Item_Type {
		get {return type;}
		set {type = value;}
	}

	// Gets and sets the item's stackability
	public bool Is_Stackable {
		get {return isStackable;}
		set {isStackable = value;}
	}

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	protected virtual void Start () {
		itemIcon = gameObject.GetComponent<Sprite> ();
	}

	// Update is called once per frame
	protected virtual void Update () {

	}

	#endregion
}
