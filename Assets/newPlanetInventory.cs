using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class newPlanetInventory : MonoBehaviour {

	public int sporeCount, totalSpores;
	public Text sporeCountText;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("UpdateSporeCount", 0, 1f);
	}
	
	void UpdateSporeCount(){
		sporeCountText.text = "" + sporeCount;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
