using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseableItem : BaseItem {

	#region Data Members

	public bool stackable;							// Tells whether or not a item is stackable
	private Dictionary<string, int> statsModifier;  // Contains the name of the stat and its modifier

	#endregion

	#region Setters & Getters

	// Gets and sets the item name
	public bool Is_Stackable {
		get {return stackable;}
		set {stackable = value;}
	}

	// Gets and sets the stat and its modifier
	public Dictionary<string,int> Item_Bonus_Stat_Modifier
	{
		get{ return statsModifier; }
		set{ statsModifier = value; }
	}

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	protected override void Start() 
	{
		base.Start ();
		statsModifier = new Dictionary<string, int> ();
	}

	// Update is called once per frame
	protected override void Update () {

	}

	#endregion

	#region Public Methods

	#endregion

	#region Private Methods

	#endregion
}
