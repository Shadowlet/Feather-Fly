using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {
    public GameObject firstBlock;

    public GameObject centerBlocks;
    public GameObject topBlocks;
    public GameObject bottomBlocks;
    public GameObject cannonBottomBlock;
    public GameObject cannonTopBlock;
    public GameObject fanBlock;
    public GameObject vacuumBlock;
    public GameObject fanTopBlock;
    public GameObject vacuumTopBlock;
    public GameObject doubleVacuumTopBlock;
    


        


    // Use this for initialization
    void Start () {

     

        int blockDistance = 20;

        // Currently creates floats of each
        float firstBlockX = firstBlock.transform.position.x;
        float firstBlockY = firstBlock.transform.position.y;


        for (int i = 2; i < 10; i++)
        {
            int blockID = Random.Range(1, 11);
            //Debug.Log(blockID);


            //---**CHANGE TO SWITCH**---//
            // Bottom blocks...
            if (blockID == 1) {
                Instantiate(centerBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 2.5f, -4), this.transform.rotation); // Center Bottom
                Instantiate(centerBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 10, -4), this.transform.rotation);   // Center Top

            }

            // Top blocks...
            else if (blockID == 2)
            {
                Instantiate(topBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Top
            }
            // Bottom blocks...
            else if (blockID == 3)
            {
                Instantiate(bottomBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Bottom
            }
            // Cannon Bottom blocks....
            else if (blockID == 4)
            {
                Instantiate(cannonBottomBlock, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Cannon Bottom

            }
            // Cannon Top blocks...
            else if (blockID == 5)
            {
                Instantiate(cannonTopBlock, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Cannon Top

            }
            else if (blockID == 6)
            {
                Instantiate(vacuumBlock, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Vacuum Bottom
            }
            else if (blockID == 7)
            {
                Instantiate(fanBlock, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Fan Bottom
            }
            else if (blockID == 8)
            {
                Instantiate(fanTopBlock, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Fan Bottom
            }
            else if (blockID == 9)
            {
                Instantiate(vacuumTopBlock, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Fan Bottom
            }
            else if (blockID == 10)
            {
                Instantiate(doubleVacuumTopBlock, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Fan Bottom
            }
        }

    }

	
	// Update is called once per frame
	void Update () {
		
	}

    
}
