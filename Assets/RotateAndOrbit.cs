using UnityEngine;
using System.Collections;

public class RotateAndOrbit : MonoBehaviour {

    public float RotationSpeed = 100f;
    public int OrbitSpeed = 120;
    public float DesiredMoonDistance = 4;
    public Transform target;
	int randX, randY, randZ;

    void Start () {
		OrbitSpeed = Random.Range(OrbitSpeed/4, OrbitSpeed);
		target = transform.parent;
       // DesiredMoonDistance = Vector3.Distance(target.position, transform.position);
		randX = Random.Range(-1,1); 
		randY = Random.Range(-1,1); 
		randZ = Random.Range(-1,1); 
		if (randX == 0 && randY == 0 && randZ == 0){
			randX = 1;
		}
		
    }

    void Update () {
      transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);
	
		
        transform.RotateAround(target.position, new Vector3(randX,randY,randZ), OrbitSpeed * Time.deltaTime);

        //fix possible changes in distance
        float currentMoonDistance = Vector3.Distance(target.position, transform.position);
        Vector3 towardsTarget = transform.position - target.position;
        transform.position += (DesiredMoonDistance - currentMoonDistance) * towardsTarget.normalized; 	
    }
}