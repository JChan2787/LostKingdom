using UnityEngine;
using System.Collections;

public class BaseCharacter : MonoBehaviour {

	#region Member
	public Animator anim;				// The animation for the character.
	public Rigidbody rig;				// The character's rigging.
	protected UnitStats statTable;		// The character's stats table.
	[SerializeField]			
	protected string characterName;		// The character's name.
	protected float sightRange;			// The range of the character's sight.

	#endregion

	#region UnitBuiltInMethod
	// Use this for initialization
	protected void Start(){
	}
		
	#endregion

	public virtual UnitStats CharacterStats {
		get{return statTable;}
		set{statTable = value;}
	}

	#region MainMethod
	public virtual void MoveThisUnit(float direction){
		rig.velocity = new Vector3(direction * statTable.AttributeValue(6),rig.velocity.y);
		anim.SetFloat("speed",direction* statTable.AttributeValue(6)) ;
	}

	public virtual float PercentHealth() 
	{
		return 0.0f;//(statTable.healthPoint / statTable.maxHealthPoint);
	}

	public virtual float PercentMana()  
	{
		return 0.0f;//(statTable.magicPoint / statTable.maxMagicPoint);
	}


	public virtual bool IsDead()
	{
		return true;//(statTable.healthPoint != 0.0f);
	}
	public	virtual void TakeDamage(float damageValue){
//		statTable.healthPoint -= damageValue;
	}
	public virtual void Kill()
	{
//		statTable.healthPoint = 0.0f;
	}


#endregion



}