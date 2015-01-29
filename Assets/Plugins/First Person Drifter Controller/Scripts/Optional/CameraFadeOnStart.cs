﻿// by @torahhorse

using UnityEngine;
using System.Collections;

public class CameraFadeOnStart : MonoBehaviour
{
	public bool fadeInWhenSceneStarts = true;
	public Color fadeColor = Color.black;
	public float fadeTime = 5f;

	void Awake ()
	{
		if( fadeInWhenSceneStarts )
		{
			Fade();
		}
	}
	
	public void Fade()
	{
		CameraFade.StartAlphaFade(fadeColor, true, fadeTime);
	}
	
	public void EndScene(){
	//	CameraFade.StartAlphaFade(fadeColor,false, fadeTime);
	}
	
	public void FadeOut(){
		CameraFade.StartAlphaFade(fadeColor,false, fadeTime*2);
		//Invoke ("Restart", fadeTime-0.01f);
	}
	
	void Restart(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
