using UnityEngine;

public class timedSpawn : MonoBehaviour
{

    public GameObject objectToSpawn;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    // Start is called before the first frame update
    private void Start()
    {
        // Instantiate(objectToSpawn, transform.position, Quaternion.identity); 
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
