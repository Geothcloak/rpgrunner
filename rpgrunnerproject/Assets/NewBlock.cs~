using UnityEngine;
using System.Collections;

public class NewBlock : MonoBehaviour {
	
	public Sprite antler, arrow, candle, grave, jelly, scarecrow, swim, totem;
	
	enum blockType{
		Antler,
		Arrow,
		Candle,
		Grave,
		Jelly,
		Scarecrow,
		Swim,
		Totem
	}
	blockType currentType;
	
	void OnEnable(){
		RandomizeSprite();
	}

	void RandomizeSprite(){
		int randomNumber = Random.Range(0,8);
		switch (randomNumber){
		case 0:
			currentType = blockType.Antler;
			GetComponent<SpriteRenderer>().sprite = antler;
			break;
		case 1:
			currentType = blockType.Arrow;
			GetComponent<SpriteRenderer>().sprite = arrow;
			break;
		case 2:
			currentType = blockType.Candle;
			GetComponent<SpriteRenderer>().sprite = candle;
			break;
		case 3:
			currentType = blockType.Grave;
			GetComponent<SpriteRenderer>().sprite = grave;
			break;
		case 4:
			currentType = blockType.Jelly;
			GetComponent<SpriteRenderer>().sprite = jelly;
			break;
		case 5:
			currentType = blockType.Scarecrow;
			GetComponent<SpriteRenderer>().sprite = scarecrow;
			break;
		case 6:
			currentType = blockType.Swim;
			GetComponent<SpriteRenderer>().sprite = swim;
			break;
		case 7:
			currentType = blockType.Totem;
			GetComponent<SpriteRenderer>().sprite = totem;
			break;
		}

	}


}
