using UnityEngine;

public class timedSpawn : MonoBehaviour
{

    public GameObject RBC;
    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(RBC, new Vector3(0, 0, 0), Quaternion.identity); 
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
