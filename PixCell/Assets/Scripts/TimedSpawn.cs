using UnityEngine;



// <summary>
// Instantiates the attached object at a chosen freqency randomly along the y 
// axis of an attached game object
// </summary>
public class TimedSpawn : MonoBehaviour
{
    // <summary>
    // The object to be instatiated
    // </summary>
    public GameObject ObjectToSpawn;

    // <summary>
    // Freqency of instantiating
    // </summary>
    public float TimeToSpawn;

    private float CurrentTimeToSpawn;

    public Vector2 center;
    
    public Vector2 size;

    public Transform spawner;

    private PlayerSwitchLogic playerSwitch;

    public bool spawnTrigger;
    // TODO: 
    // - Create an array of objects to be chosen at random
    // - Create an array of vector positions to choose at random
    private void Start()
    {

    }
    private void Update()
    {
        if(CurrentTimeToSpawn > 0)
        {
            CurrentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            CurrentTimeToSpawn = TimeToSpawn;
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
        Instantiate(ObjectToSpawn, pos, Quaternion.identity);
        // for (int i = 1; i < Players.Length; i++)
        // {
            
        // }
    }
    
    // public void SpawnRbc()
    // {
    //     Vector2 pos = new Vector2(transform.position.x, Random.Range(-size.y / 2, size.y / 2));
    //     Instantiate(ObjectToSpawn, pos, Quaternion.identity); 
    // }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition, size);
    }
}
