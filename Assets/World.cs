using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public Player player;
	public WorldNeeds worldNeeds;
	public Map map;

	void Start(){
		//Besoins
		this.worldNeeds = new WorldNeeds(this);
		this.worldNeeds.InitializeNeeds();
		this.player.manager.InitializeManager ();

		this.player.AddBuildingInMap(new Building(), 0, 0);
		this.player.AddBuildingInMap(new Building(), 0, 0);
		this.player.AddBuildingInMap(new Building(), 0, 0);

		Building industry = new Building();
		industry.need.SetNeedType((int)WorldNeeds.types.INDUSTRY_TYPE);
		this.player.AddBuildingInMap(industry, 0, 0);
		this.player.AddBuildingInMap(industry, 0, 0);

		Building office = new Building();
		office.need.SetNeedType((int)WorldNeeds.types.OFFICE_TYPE);
		this.player.AddBuildingInMap(office, 0, 0);
	}
}
