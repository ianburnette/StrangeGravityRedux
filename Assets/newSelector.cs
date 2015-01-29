using UnityEngine;
using System.Collections;

public class newSelector : MonoBehaviour {

	public LayerMask mask;
	public float range = 2000;
	public RaycastHit highlightHit;
	private RaycastHit hit;
	public Shader highlightShader;
	private Shader defaultShader;
	newSelectedPlanets selectedPlanetsScript;
	
	
	public Transform currentlyHighlightedPlanet, lastSelectedPlanet;
	
	void Start () {
		selectedPlanetsScript = GetComponent<newSelectedPlanets>();
		InvokeRepeating("CheckToHighlight", .1f, .1f);
	}
	
	void Update () {
		Debug.DrawRay(transform.position, transform.forward*range, Color.green);
		if (Input.GetButtonDown("Fire1")){
			CheckToSelect();
		}
		
	}
	
	void CheckToSelect(){
		RaycastHit selectHit;
		if (Physics.Raycast (transform.position, transform.forward, out selectHit, range, mask)){
			int degree = selectedPlanetsScript.ClickedOn(selectHit.transform);
			if (degree == 1){ //list 1
				selectHit.transform.parent.GetComponent<newHighlightScript>().Highlight(2);
			} else if (degree == 2) { //list 2
				selectHit.transform.parent.GetComponent<newHighlightScript>().Highlight(3);
			} else{ //deselect
				selectHit.transform.parent.GetComponent<newHighlightScript>().StopSelecting();
			}
		}
	}
	
	void CheckToHighlight(){
		if (Physics.Raycast (transform.position, transform.forward, out highlightHit, range, mask)){
			if (highlightHit.transform.tag != "floor"){
				currentlyHighlightedPlanet = highlightHit.transform;
				if (lastSelectedPlanet == null){
					lastSelectedPlanet=currentlyHighlightedPlanet;
					currentlyHighlightedPlanet.transform.parent.GetComponent<newHighlightScript>().Highlight(1);
				}
				else if (lastSelectedPlanet != currentlyHighlightedPlanet && lastSelectedPlanet!=null){
					lastSelectedPlanet.GetComponent<newHighlightScript>().StopHighlighting();
				}
				else if (lastSelectedPlanet == currentlyHighlightedPlanet){
					
				}
				
				if (lastSelectedPlanet != null && lastSelectedPlanet != currentlyHighlightedPlanet){
					
				}
			}
		}
		else{
			currentlyHighlightedPlanet = null;
		}
		if (lastSelectedPlanet != null && currentlyHighlightedPlanet == null){
			lastSelectedPlanet.transform.parent.GetComponent<newHighlightScript>().StopHighlighting();
			lastSelectedPlanet = null;
		}
	}
	
	void UpdateHighlights(Transform toUpdate){
		
	}
}
