using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoor : MonoBehaviour {

    public GameObject door;
    public int currentParts = 0;

    private int requiredParts = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (currentParts <= requiredParts)
            {
                door.SetActive(false);
            }
            
        }
    }
}
