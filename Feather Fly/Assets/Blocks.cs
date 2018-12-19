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
    


        


    // Use this for initialization
    void Start () {

        // distance...
        new Vector3(20, 0, 0);

        int blockDistance = 20;

        // Currently creates 8 floats of each
        float firstBlockX = firstBlock.transform.position.x;
        float firstBlockY = firstBlock.transform.position.y;


        for (int i = 2; i < 10; i++)
        {
            int blockID = Random.Range(1, 6);
            Debug.Log(blockID);


            //---**CHANGE TO SWITCH**---//
            // Bottom blocks...
            if (blockID == 1) {
                Instantiate(centerBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 2.5f, -4), this.transform.rotation); // Bottom
                Instantiate(centerBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 10, -4), this.transform.rotation);   // Top

            }

            // Top blocks...
            else if (blockID == 2)
            {
                Instantiate(topBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Bottom
            }
            // Bottom blocks...
            else if (blockID == 3)
            {
                Instantiate(bottomBlocks, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Bottom

            }
            // Cannon Bottom blocks....
            else if (blockID == 4)
            {
                Instantiate(cannonBottomBlock, new Vector3(firstBlockX + blockDistance * i - 20, 4.5f, -4), this.transform.rotation); // Bottom

            }
            // Cannon Top blocks...
            else if (blockID == 5)
            {
                Instantiate(cannonTopBlock, new Vector3(firstBlockX + blockDistance * i - 20, 8, -4), this.transform.rotation); // Bottom

            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
