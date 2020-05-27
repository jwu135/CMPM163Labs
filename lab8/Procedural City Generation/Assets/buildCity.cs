using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
	public GameObject[] buildings;
	public int mapWidth = 20;
	public int mapHeight = 20;
	int buildingFootprint = 3;

    // Start is called before the first frame update
    void Start()
    {
    	float seed = Random.Range(0,100);
    	Debug.Log(seed);
        for (int h = 0; h < mapHeight; h++){
        	for (int w = 0; w < mapWidth; w++) {
        		int result = (int) (Mathf.PerlinNoise(w/10.0f + seed,h/10.0f + seed) * 12);
        		Vector3 posGrass = new Vector3(w * buildingFootprint,0,h * buildingFootprint);
        		Vector3 pos = new Vector3(w * buildingFootprint,0.5f,h * buildingFootprint);
        		// int n = Random.Range(0,buildings.Length);
        		// Instantiate(buildings[n],pos,Quaternion.identity);
        		// if (result < 6)	// water
        		// 	Instantiate(buildings[6],pos,Quaternion.identity);
        		if (result >= 6) {
        			Instantiate(buildings[5],posGrass,Quaternion.identity);
        			if (result > 7) {
        				if (result < 8)
        					Instantiate(buildings[0],pos,Quaternion.identity);
    					else if (result < 9)
    						Instantiate(buildings[1],pos,Quaternion.identity);
    					else if (result < 10)
    						Instantiate(buildings[2],pos,Quaternion.identity);
    					else if (result < 11)
    						Instantiate(buildings[3],pos,Quaternion.identity);
    					else if (result < 12)
    						Instantiate(buildings[4],pos,Quaternion.identity);
    				}
				}
        	}
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
