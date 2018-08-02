using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDoor : MonoBehaviour {

    public GameObject door1;
    public GameObject door2;
    public int currentParts = 0;
    public Text interactText;

    private int requiredParts = 4;

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
            if (currentParts == requiredParts)
            {
                door1.SetActive(false);
                door2.SetActive(false);
            }
            else
            {
                interactText.text = "More spare parts are required";
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interactText.text = "";
        }
    }
}
