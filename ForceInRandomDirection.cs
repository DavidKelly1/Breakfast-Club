using UnityEngine;
using System.Collections;

public class ForceInRandomDirection : MonoBehaviour {

    public float forceAmount = 30.0f;
    public ForceMode forceMode;
    public string buttonName = "Fire1";
    public float torqueAmount = 50.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetButtonDown(buttonName))
        {
            GetComponent<Rigidbody>().AddForce(Random.onUnitSphere*forceAmount,forceMode);
            GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * torqueAmount, forceMode);
        }
	}
}
