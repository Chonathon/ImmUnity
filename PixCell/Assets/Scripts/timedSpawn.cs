using UnityEngine;

public class timedSpawn : MonoBehaviour
{

    public GameObject objectToSpawn;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    public bool spawnTrigger;
    // TODO: 
    // - Create an array of objects to be chosen at random
    // - Create an array of vector positions to choose at random
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity); 
    }
}
