using UnityEngine;
using System.Collections;

public class DisplayCurrentDieValue : MonoBehaviour {

    public LayerMask dieValueColliderLayer = -1;
    public int currentHearts;
    public int currentSurge;
    public int currentDefense;
    public int currentRange;


    private bool rollComplete = false;

	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
    
        if(Physics.Raycast(transform.position,Vector3.up,out hit, Mathf.Infinity, dieValueColliderLayer))
        {
            currentHearts = hit.collider.GetComponent<DieValue>().hearts;
            currentSurge = hit.collider.GetComponent<DieValue>().surge;
            currentDefense = hit.collider.GetComponent<DieValue>().defense;
            currentRange = hit.collider.GetComponent<DieValue>().range;
        }
        if(GetComponent<Rigidbody>().IsSleeping() && !rollComplete)
        {
            rollComplete = true;
            Debug.Log("Die roll complete, die is at rest");
        }

        else if(!GetComponent<Rigidbody>().IsSleeping())
        {
            rollComplete = false;
        }
	}

    
}
