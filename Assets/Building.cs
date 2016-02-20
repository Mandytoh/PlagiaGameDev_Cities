using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

	public int width = 2;
	public int height = 2;
	public Need need;

	public int defaultValue = 100;

	public Building(){
		this.need = new Need ();
		need.SetNeedType ((int)WorldNeeds.types.HOUSE_TYPE);
		need.SetNeedValue (defaultValue);
	}

	public void setNeedType( int newType ){
		this.need.SetNeedType (newType);
	}
}
