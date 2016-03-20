using UnityEngine;
using System.Collections;

public class NonUseableItem : BaseItem {
	#region Data Members

	private bool isCraftable; // Determines whether or not a specific item is craftable

	#endregion

	#region Setters & Getters

	// Gets and sets the value of isCraftable
	public bool Is_Craftable {
		get {return isCraftable;}
		set {isCraftable = value;}
	}

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	protected override void Start () {
		base.Start ();

	}

	// Update is called once per frame
	protected override void Update () {
		base.Start ();
	}

	#endregion
}
