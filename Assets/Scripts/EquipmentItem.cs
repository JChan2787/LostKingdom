using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This enumeration describes all the body parts that any
// appropriate items can be used on.
public enum BodyPart {
	HEAD,
	ARMS,
	HANDS,
	TORSO,
	LEGS,
	FEET,
	MISC
};

public class EquipmentItem : UseableItem {
	
	#region Data Members

	private Mesh itemGeo;								// The geometry mesh of the item.
	private Dictionary<string, int> statsRequirement;	// The stats requirements of the item.
	public string model;								// The model for the item.
	private BodyPart bodyPart;							// The body part the item belongs to.

	#endregion

	#region Setters & Getters

	// Gets the geometry mesh of the item.
	public Mesh Get_Item_Geo
	{
		get { return itemGeo; }
	}

	// Gets and sets the stats requirements.
	public Dictionary<string, int> Item_Stats_Requirement
	{
		get { return statsRequirement; }
		set { statsRequirement = value; }
	}

	// Gets and sets the item type
	public BodyPart Body_Part {
		get {return bodyPart;}
		set {bodyPart = value;}
	}

	#endregion

	#region Built-In Unity Methods

	// Use this for initialization
	protected override void Start () 
	{
		base.Start ();
		itemGeo = new Mesh();
	}

	// Update is called once per frame
	protected override void Update ()
	{

	}

	#endregion

	#region Public Methods


	#endregion

	#region Private Methods


	#endregion
}
