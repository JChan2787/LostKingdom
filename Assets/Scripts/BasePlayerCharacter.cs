using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BasePlayerCharacter : BaseCharacter {

	#region Member
	//public List<BaseSkill> activeSkill;
	//public SkillTree skillTree;
	public List <int> activeItem;
	public List<BaseItem> inventory;
	public int charLevel;
	//protected JobClass classType;
	protected int index;
//	protected UnitDB charDB;

	#endregion

	public void Init(int i){
		base.statTable = new UnitStats();
		index = i;
		//charDB = FindObjectOfType<UnitDB>();
		//charDB.SetUnitStat(base.statTable,index);
		//charDB.SetUnitInfo(this,index);
	}

	#region MainMethod
	public string CharacterName {
		get{ return  base.characterName; }
		set{ base.characterName = value; }
	}

	public override UnitStats CharacterStats {
		get{return base.statTable;}
		set{base.statTable = value;}
	}


	public virtual float PercentageStamina(){
		return 0.0f;//(statTable.staminaPoint/statTable.maxStaminaPoint);
	}



	public virtual void BasicAttack(){}

	public virtual void Jump(){
		rig.velocity = new Vector2(5.0f,rig.velocity.y);
	}
	#endregion

}
