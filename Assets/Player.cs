using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Manager manager;

	public Building AddBuildingInMap(Building building, int x, int y){
		this.manager.AddBuilding (building);
		return building;
	}

}
