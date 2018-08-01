using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerEnergy : MonoBehaviour {

    public float energy = 30;
    public int parts;

    public Text energyText;
    public Text interactText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        energy -= 1 * Time.fixedDeltaTime;
        energyText.text = "power " + energy;

		if (energy <= 0) 
		{
			Application.LoadLevel ("Main");
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spark")
        {
            interactText.text = "SPACE take parts and recharge";
        }

        if (other.tag == "Door")
        {
            GameObject.Find("door trigger").GetComponent<TestDoor>().currentParts = parts;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Spark")
        {
            interactText.text = "";
        }
    }
}
