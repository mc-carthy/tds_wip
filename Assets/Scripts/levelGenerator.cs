using UnityEngine;
using System.Collections;

public class levelGenerator : MonoBehaviour {

	public GameObject[] wallTiles;
	[Range(0, 50)]
	public int roomSizeMin;
	[Range(1, 75)]
	public int roomSizeMax;
	public bool squareRooms;
	public int numberOfRooms = 1;

	void Start () {
		GenerateRoom ();
	}

	void GenerateRoom() {
		GameObject firstWallTile = wallTiles [0];
		SpriteRenderer wallSprite = firstWallTile.GetComponent<SpriteRenderer> ();
		float wallHeight = wallSprite.sprite.rect.height;
		float wallWidth = wallSprite.sprite.rect.width;

		int roomHeight = 3 + Random.Range (roomSizeMin, roomSizeMax);
		int roomWidth = (squareRooms) ? roomHeight : 3 + Random.Range (roomSizeMin, roomSizeMax);

		for (int x = 0; x <= roomWidth; x++) {
			for (int y = 0; y <= roomHeight; y++) {
				if (x == 0 || x == roomWidth || y == 0 || y == roomHeight) {
					GameObject wall = (GameObject)Instantiate (firstWallTile, new Vector3 (x, y), Quaternion.identity);
					wall.transform.SetParent (transform);
				}
			}
		}
	}
}
