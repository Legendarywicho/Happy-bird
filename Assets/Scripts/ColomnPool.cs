using UnityEngine;
using System.Collections;

public class ColomnPool : MonoBehaviour {


	private GameObject[] columns;
	public int ColumnPoolSize= 5;
	public GameObject columnPrefab;
	private Vector2 carl = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawn;

	public float rate= 4f;
	public float min= -1f;
	public float max= 3.5f;
	private float spawnxPosition= 10f;
	private int currentColumn=0;

	// Use this for initialization
	void Start () {

		columns = new GameObject[ColumnPoolSize];

		for (int i = 0; i < ColumnPoolSize; i++) {
			columns [i] = (GameObject)Instantiate (columnPrefab, carl, Quaternion.identity);

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timeSinceLastSpawn += Time.deltaTime;

		if (GameControl.instance.GameOver == false && timeSinceLastSpawn >= rate) {

			timeSinceLastSpawn = 0;
			float spawnYPosition = Random.Range (min, max);
			columns [currentColumn].transform.position = new Vector2 (spawnxPosition, spawnYPosition);
			currentColumn++;

			if (currentColumn>=ColumnPoolSize) {

				currentColumn = 0;
				
			}
		}

	}
}
