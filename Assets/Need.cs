using UnityEngine;
using System.Collections;

public class Need : MonoBehaviour {

	private int type;
	private float value;

	public int SetNeedType( int newType ){
		this.type = newType;
		return this.type;
	}
	public int GetNeedType(){
		return this.type;
	}

	public float SetNeedValue( float newValue ){
		this.value = newValue;
		return this.value;
	}
	public float GetNeedValue(){
		return this.value;
	}
}
