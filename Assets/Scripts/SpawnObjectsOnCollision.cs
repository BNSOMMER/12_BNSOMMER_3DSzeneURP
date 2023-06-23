using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsOnCollision : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public int numberOfObjectsToSpawn = 3; 

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision:"+ collision.gameObject.name);
        Debug.Log("collision.gameObject" );
        if (collision.gameObject.name == "TestObject")
        {
            {
                Debug.Log("Jetzt würden mehr Objekte spawnen");
            }

            for (int i = 0; i < numberOfObjectsToSpawn; i++)
            {
                GameObject spawnedObject = Instantiate(objectToSpawn, transform.position + new Vector3(i, 0, 0), Quaternion.identity);
            }
        }
    }
}
