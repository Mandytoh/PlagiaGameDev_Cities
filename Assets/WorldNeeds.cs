using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class WorldNeeds : MonoBehaviour {

	public enum types {HOUSE_TYPE, OFFICE_TYPE,  INDUSTRY_TYPE,  HOBBY_TYPE};
	private List<Need> needs;
	public World world;

	public WorldNeeds( World newWorld){
		this.needs = new List<Need> ();
		this.world = newWorld;
	}

	public bool InitializeNeeds( int defaultValue = 1000 ){
		foreach (int type in Enum.GetValues(typeof(WorldNeeds.types))) {
			Need need = new Need();
			need.SetNeedType(type);
			need.SetNeedValue(defaultValue);
			needs.Add(need);
		}
		return true;
	}

	public List<Need> GetNeeds(){
			return this.needs;
	}
	
	public Need GetNeed( int index){
		return this.needs[index];
	}
}
