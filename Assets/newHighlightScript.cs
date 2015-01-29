using UnityEngine;
using System.Collections;

public class newHighlightScript : MonoBehaviour {

	public Shader myShader, highlightShader;
	public Transform planetBody;
	bool selected = false;

	// Use this for initialization
	void Start () {
		myShader = planetBody.renderer.material.shader;
	}
	
	// Update is called once per frame
	public void StopHighlighting() {
		if (!selected)
			planetBody.renderer.material.shader = myShader;
	}
	
	public void StopSelecting() {
		planetBody.renderer.material.shader = myShader;
		selected = false;
	}
	
	public void Highlight(int degree){
		if (planetBody.renderer.material.shader != highlightShader){
			planetBody.renderer.material.shader = highlightShader;
		}
		if (degree == 1){
			if (!selected)
				planetBody.renderer.material.SetColor ("_OutlineColor", Color.green);
		}
		if (degree == 2){
			planetBody.renderer.material.SetColor ("_OutlineColor", Color.blue);
			selected = true;
		}
		if (degree == 3){
			planetBody.renderer.material.SetColor ("_OutlineColor", Color.yellow);
			selected = true;
		}
	}
}
