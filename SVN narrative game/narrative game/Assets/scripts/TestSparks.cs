using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSparks : MonoBehaviour {

    public GameObject sparks;
    public GameObject clunk;
    public GameObject parts;
    public GameObject eyeLightWhite;
    public GameObject eyeLightRed;
    private bool inPosition = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inPosition == true)
        {
            sparks.SetActive(false);
            clunk.SetActive(true);
            parts.SetActive(false);
            eyeLightWhite.SetActive(false);
            eyeLightRed.SetActive(true);

            GameObject.Find("FPS_Player").GetComponent<PlayerEnergy>().parts++;
			GameObject.Find("FPS_Player").GetComponent<PlayerEnergy>().energy += 20;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inPosition = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inPosition = false;
        }
    }
}
