using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject RedObject;
    public GameObject BrownObject;
    public GameObject GreenObject;
    float PositionY;
    float Rand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        Rand = Random.Range(1, 4);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        if (Rand == 1)
        {
            Instantiate(RedObject, transform.position, transform.rotation);
        }
        if (Rand == 2)
        {
            Instantiate(BrownObject, transform.position, transform.rotation);
        }
        if (Rand == 3)
        {
            Instantiate(GreenObject, transform.position, transform.rotation);
        }
    }
}
