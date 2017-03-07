using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject fish;
    public Transform fishSpawner;

    private bool fishDropped;
    
	void Start () {
        fishDropped = false;

	}
	
	void Update () {

        //if(!fishDropped && Input.GetKeyDown(KeyCode.F)) {
        if(Input.GetKeyDown(KeyCode.F)) {
            // drop fish
            Instantiate(fish, fishSpawner.position, Quaternion.identity);
            fishDropped = true;
        }
	}
}
