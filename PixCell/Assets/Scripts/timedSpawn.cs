using UnityEngine;

public class timedSpawn : MonoBehaviour
{

    public GameObject objectToSpawn;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    public Vector2 center;
    
    public Vector2 size;

    public Transform spawner;

    public playerSwitchLogic playerSwitch;

    public bool spawnTrigger;
    // TODO: 
    // - Create an array of objects to be chosen at random
    // - Create an array of vector positions to choose at random
    // - Start is called before the first frame update
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
            // TODO:
            // - if spawn object tag == RBC || WBC 
            // - add to Player array
            // foreach (playerSwitch.Players player in players)
            // {
            //     players.Add(objectToSpawn);
            // }
        }

    }

    public void SpawnObject()
    {
        Vector2 pos = new Vector2(transform.position.x, Random.Range(-size.y / 2, size.y / 2));
        Instantiate(objectToSpawn, pos, Quaternion.identity); 
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition, size);
    }
}
