// This script is placed in public domain. The author takes no responsibility for any possible harm.

// Moves the object along as far as range units randomly but in a smooth way.
// This script requires the Noise.cs script.
var speed = 1.0f;
var range = Vector3 (1.0, 1.0, 1.0);

private var noise = new Perlin();
private var position : Vector3;

function Start()
{
	position = transform.position;
	range = new Vector3 (.1,.1,.1);// new Vector3 (position.x+Random.Range(-10,10),position.y+Random.Range(-10,10),position.z+Random.Range(-10,10));
	speed = Random.Range (-.5f,.5f);
	position = transform.position;
}

function Update () {
	transform.position = position + Vector3.Scale(SmoothRandom.GetVector3(speed), -range);
}

function Death(){
	this.enabled = false;
}