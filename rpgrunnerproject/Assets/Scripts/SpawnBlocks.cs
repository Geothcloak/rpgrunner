using UnityEngine;
using System.Collections;

public class SpawnBlocks : MonoBehaviour {
	
	public bool isSpawn;
	public GameObject[] blockPrefabs; 
	GameObject[,] blocksInPlay;

	// Use this for initialization
	void Start () {
		blocksInPlay = new GameObject[8,8];
		if (isSpawn){
			for ( int i = 7; i >= 0; i-- ){
				for ( int ii = 7; ii >= 0; ii--){
					GameObject tempGameObject;
					//i = columns   ii = rows	
				    tempGameObject =  Instantiate(blockPrefabs[Random.Range(0,8)], new Vector3(i-3.5f,ii-5f,0), Quaternion.identity) as GameObject;
					blocksInPlay[i,ii] = tempGameObject;
				}
			}
			
		}
	
	
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	





}
