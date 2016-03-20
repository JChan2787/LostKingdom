using UnityEngine;
using System.Collections;

public class ConsumableItem : UseableItem, IConsumableItem {

	#region Data Members

	public Sprite itemSprite;	// Contains the sprite for a specific item
	public float itemRange;		// Describes the range of the item's effects

	#endregion

	#region Setters & Getters

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	protected override void Start () {

	}

	// Update is called once per frame
	protected override void Update () {

	}

	#endregion

	#region Public Methods

	// Activates a specific item in the inventory
	public void ActivateItem() {
		
	}

	#endregion

	#region Private Methods

	#endregion

}
