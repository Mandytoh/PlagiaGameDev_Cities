using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Manager : MonoBehaviour {

	public RectTransform needsUI;
	public List<Building> buildings = new List<Building>();
	public WorldNeeds worldResponses;
	public WorldNeeds worldResults;
	public World world;

	public void InitializeManager(){
		this.worldResponses = new WorldNeeds(this.world);
		this.worldResponses.InitializeNeeds(0);

		this.worldResults = new WorldNeeds(this.world);
		this.worldResults.InitializeNeeds();

		this.UpdateNeedsUI( this.worldResults.GetNeeds() );
	}

	public Building AddBuilding( Building building ){
		this.buildings.Add (building);
		UpdateResponseValue (building);
		return building;
	}

	public void UpdateResponseValue(Building building){
		foreach (Need response in this.worldResponses.GetNeeds()) {
			if(response.GetNeedType() == building.need.GetNeedType()){
				float newValue = response.GetNeedValue() + building.need.GetNeedValue();
				response.SetNeedValue(newValue);
			}
		}
		this.RecalculateNeeds (this.worldResponses.GetNeeds());
		this.UpdateNeedsUI (this.worldResults.GetNeeds ());
	}
	
	public void RecalculateNeeds( List<Need> responses ){
		int worldResultsCount = this.worldResults.GetNeeds().Count;
		for (int i = 0; i < worldResultsCount; i++) {
			float rest = this.world.worldNeeds.GetNeed(i).GetNeedValue() - responses[i].GetNeedValue();
			this.worldResults.GetNeed(i).SetNeedValue(rest);
		}
	}

	public void UpdateNeedsUI( List<Need> needs ){
		needsUI.GetComponent<Text> ().text = "";
		foreach (Need need in needs) {
			needsUI.GetComponent<Text>().text += need.GetNeedType() + " : " + need.GetNeedValue() + '\n';
		}
	}
}
