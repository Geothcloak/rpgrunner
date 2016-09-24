using UnityEngine;
using System.Collections;

public class SwapBlocks : MonoBehaviour {
	public Vector3[] blockPosition;
	public GameObject[] blockForSwitch;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("pressed left mouse");
			GetPosition(0);
		}	
		if (Input.GetMouseButtonUp(0)){
			Debug.Log("released left mouse");
			GetPosition(1);
			Swap();
		}
	}
	
	void GetPosition(int blockIndex){
		var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit;
		hit = Physics2D.Raycast (new Vector2(mousePosition.x,mousePosition.y),Vector2.zero,Mathf.Infinity);
		if (hit != null && hit.collider != null){
		//	SpriteRenderer blockRenderer = hit.collider.gameObject.GetComponent<SpriteRenderer>();
		//	blockRenderer.color = Color.white; 
			blockPosition[blockIndex] = hit.collider.gameObject.transform.position;
		   	blockForSwitch[blockIndex] = hit.collider.gameObject;
				
			
			
		}
	}

	void Swap() {
		
		Vector3 tempVector3 = blockPosition[0];
	//	blockPosition[0].transfom.position = blockPosition[1];
	//	blockPosition[1].transform.position = tempVector3;


		
		GameObject tempGameObject = blockForSwitch[0];
		blockForSwitch[0] = blockForSwitch[1];
		blockForSwitch[1] = tempGameObject;
	
	}
}
