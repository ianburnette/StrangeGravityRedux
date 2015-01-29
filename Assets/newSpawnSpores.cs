using UnityEngine;
using System.Collections;

public class newSpawnSpores : MonoBehaviour {

	public Transform planetBody;
	public GameObject spore;
	public float waitTime;
	bool stunned;
	newPlanetInventory inventoryScript;

	// Use this for initialization
	void Start () {
		inventoryScript = GetComponent<newPlanetInventory>();
		planetBody = transform.GetChild(0);
		InvokeRepeating("SpawnSpore", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void SpawnSpore(){
		if (inventoryScript.sporeCount < inventoryScript.totalSpores){
			//print (""+Random.onUnitSphere);
			GameObject newSpore = Instantiate(spore, transform.position + Random.onUnitSphere * 5, Quaternion.identity) as GameObject;
			//print (newSpore.transform.position);
			newSpore.transform.parent = planetBody;
			RotateAndOrbit rotateScript = newSpore.GetComponent<RotateAndOrbit>();
			rotateScript.target = planetBody;
			rotateScript.DesiredMoonDistance = transform.localScale.x * 5;
			StartCoroutine(BeginOrbit(rotateScript));
			//rotateScript.enabled = true;
			//newSpore.GetComponent<RotateAndOrbit>().target = planetBody;
			inventoryScript.sporeCount ++;
			
		}
	}
	
	IEnumerator BeginOrbit(RotateAndOrbit currentRotateScript){
		yield return new WaitForSeconds(waitTime);
		currentRotateScript.enabled = true;
	}
}
