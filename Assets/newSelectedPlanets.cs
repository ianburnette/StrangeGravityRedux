using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class newSelectedPlanets : MonoBehaviour {

	public List<Transform> selectedPlanetList = new List<Transform>();
	public List<Transform> doubleSelectedPlanetList = new List<Transform>();

	public int ClickedOn(Transform clickedPlanet){
		if (selectedPlanetList.Contains(clickedPlanet)){
			RemovePlanet(clickedPlanet, 1);
			AddPlanet(clickedPlanet, 2);
			return 2;
		}
		else if (doubleSelectedPlanetList.Contains(clickedPlanet)){
			RemovePlanet(clickedPlanet, 2);
			return 3;
		}
		{
			AddPlanet(clickedPlanet, 1);
			return 1;
		}
	}
	
	public void AddPlanet(Transform planetToAdd, int list){
		if (list == 1){
			selectedPlanetList.Add(planetToAdd);
		}
		else {
			doubleSelectedPlanetList.Add(planetToAdd);
		}
	}
	
	public void RemovePlanet(Transform planetToRemove, int list){
		if (list == 1){
			int index = selectedPlanetList.IndexOf(planetToRemove);
			selectedPlanetList.RemoveAt(index);
		}
		else{
			int index = doubleSelectedPlanetList.IndexOf(planetToRemove);
			doubleSelectedPlanetList.RemoveAt(index);
		}
	}
	
	public void RemoveAllPlanets(){
		
	}
}
