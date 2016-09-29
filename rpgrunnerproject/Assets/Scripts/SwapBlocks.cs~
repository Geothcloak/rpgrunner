using UnityEngine;
using System.Collections;

public class SwapBlocks : MonoBehaviour {
	//holder for vector positions of blocks for swap
	public Vector3[] blockPosition;
	//holder for gameobjects for swapping
	public GameObject[] blockForSwitch;
	
	//array of all current blocks in play in order to do checks
	GameObject[,] blocksInPlay;

	//type of block that we spawn in that is random on spawn.
	public GameObject genericBlock;

	void Start () {
		//populate game
		NewGameSpawn();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Debug.Log("pressed left mouse");
			//after holding down mouse get the first blocks position
			GetPosition(0);
		}	
		if (Input.GetMouseButtonUp(0)){
			Debug.Log("released left mouse");
			//after letting go of mouse get second blocks position and if 
			//you choose two blocks then swap them
			GetPosition(1);
			if (blockForSwitch[0] != null && blockForSwitch[1] != null){	
				Swap();
			}
		}
	}

	//function to retreive position and gameobject to put in holder for swap.
	void GetPosition(int blockIndex){
		var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit;
		hit = Physics2D.Raycast (new Vector2(mousePosition.x,mousePosition.y),Vector2.zero,Mathf.Infinity);
		if (hit != null && hit.collider != null){ 
			blockPosition[blockIndex] = hit.collider.gameObject.transform.position;
		   	blockForSwitch[blockIndex] = hit.collider.gameObject;
		}
	}

	//swap block locations
	void Swap() {
		Vector3 tempVector3 = blockPosition[0];
		blockForSwitch[0].transform.position = blockPosition[1];
		blockForSwitch[1].transform.position = tempVector3;
		// int[2] tempFirst;
		// int[2] tempSecond;
		// GameObject tempBlocksInPlay;
		
		//	for ( int i = 7; i >= 0; i-- ){
		//		for ( int ii = 7; ii >= 0; ii--){
		//			//i = columns   ii = rows
		//			if (blocksInPlay[i,ii] == blockForSwitch[0]){ //look at there positions?
		//				tempFirst[0] = i;
		//				tempFirst[1] = ii;
		//			}
		//			if (blocksInPlay[i,ii] == blockForSwitch[1]{  // "                 "
		//				tempSecond[0] = i;
		//				tempSecond[1] = ii;
		//			}
		//
		//		}
		//	}
		//	store gameobject blocks in temp and then switch them in the array.
		//	tempBlocksInPlay = blocksInPlay[tempFirst[0], tempFirst[1]];
		//	blocksInPlay[tempFirst[0],tempFirst[1]] = blocksInPlay[tempSecond[0], tempSecond[1]];
		//	blocksInPlay[tempSecond[0], tempSecond[1]] = tempBlocksInPlay;	
		
		// swap positions in array *****************************************************************************************************		
		// check
		//
		// if no match 3 then swap back *****************************************************************************************************		
		
		
		
		//null position holders and gameobject holders to avoid bugs.	
		blockPosition[0] = Vector3.zero;
		blockPosition[1] = Vector3.zero;
		blockForSwitch[0] = null;
		blockForSwitch[1] = null;
	}
	void checkMatch(){
		int matches = 0;
		//check rows
		for ( int i = 0; i <= 7; i++ ){
				for ( int ii = 0; ii <= 6; ii++ ){
					//i = columns   ii = rows
					//
					if (blocksInPlay[ii, i] == blocksInPlay[ii + 1, i]){
						matches ++;
					}else{
						matches = 0;
					}		
					if (matches == 3){
						//delete blocks;   *******************************logic for 3 matches. 2 on end and 1 on next row counts?**********************************************************************
						//spawn in missing blocks *****************************************************************************************************
						//break;
					}
				   	
				}
		}

		//check columns	
		for ( int i = 0; i <= 6; i++ ){
				for ( int ii = 0; ii <= 7; ii++ ){
					//i = columns   ii = rows
					//
					if (blocksInPlay[ii, i] == blocksInPlay[ii, i + 1]){
						matches ++;
					}else{
						matches = 0;
					}		
					if (matches == 3){
						//delete blocks; *****************************************************************************************************
						//break; *****************************************************************************************************
					}
				   	
				}
		}
	}

	//run on awake to spawn in a new board. 
	void NewGameSpawn(){
		blocksInPlay = new GameObject[8,8];
			for ( int i = 7; i >= 0; i-- ){
				for ( int ii = 7; ii >= 0; ii--){
					GameObject tempGameObject;
					//i = columns   ii = rows	
				    //tempGameObject =  Instantiate(blockPrefabs[Random.Range(0,8)], new Vector3(i-3.5f,ii-5f,0), Quaternion.identity) as GameObject;
					tempGameObject = Instantiate(genericBlock, new Vector3(i-3.5f,ii-5f,0), Quaternion.identity) as GameObject;
					blocksInPlay[i,ii] = tempGameObject;
				}
			}	
	}
	
	
}

