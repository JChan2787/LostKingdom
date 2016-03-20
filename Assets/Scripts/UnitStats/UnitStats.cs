//using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitStats  {
	#region Data Members

	List<CharStat> listStats;
	List<CharAttribute> listAttribute;


	#endregion

	#region Setters & Getters
	public List<CharStat> ListStat{
		set{ listStats = value;}
	}

	public List<CharAttribute> ListAttribute {
		set{ listAttribute = value;}
		get{ return listAttribute;}
	}
	#endregion

	#region Builtin Method

	void Start () {
		
		listStats = new List<CharStat>();
		listAttribute = new List<CharAttribute>();
	}
		
	#endregion

	#region MainMethod

	public void StatChange(float value, int type){
		listStats[type].BaseValueChange (value) ;
	}

	public void BonusStatChange(float value, int type){
		listStats[type].BonusValueChange (value);
	}

	public void AttributeChange(float value, int type){
		listAttribute[type].BaseValueChange (value);
	}

	public void BonusAttributeChange(float value, int type){
		listAttribute[type].BonusValueChange (value);
	}

	public float StatValue(int type){
		return listStats[type].StatValue;
	}

	public float AttributeValue(int type){
		return listAttribute[type].StatValue;
	}
		
	#endregion

}
