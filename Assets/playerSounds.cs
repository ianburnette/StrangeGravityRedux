using UnityEngine;
using System.Collections;

public class playerSounds : MonoBehaviour {

	public AudioClip rollover, select, deselect, send;

	public void PlayRollover(){
		audio.PlayOneShot(rollover,1);
	}
	
	public void PlaySelect(){
		audio.PlayOneShot(select,1);
	}
	
	public void PlayDeselect(){
		audio.PlayOneShot(deselect,1);
	}
	
	public void PlaySend(){
		audio.PlayOneShot(send,1);
	}
}
