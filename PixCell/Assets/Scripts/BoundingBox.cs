using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox : MonoBehaviour
{
    // Bot Left
    [SerializeField]
    public Vector2 P1;
    // Top Left
    [SerializeField]
    public Vector2 P2;
    // Top Right
    [SerializeField]
    public Vector2 P3;
    // Bot Right
    [SerializeField]
    public Vector2 P4;

    // Start is called before the first frame update
    void Start(){        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gizmos.DrawLine(new Vector2(P1.x, P1.y), new Vector2(P2.x, P2.y));
        Debug.DrawLine(new Vector2(P1.x,P1.y),new Vector2(P2.x,P2.y), Color.green, 100f);
        Debug.DrawLine(new Vector2(P2.x,P2.y),new Vector2(P3.x,P3.y), Color.green, 100f);
        Debug.DrawLine(new Vector2(P3.x,P3.y),new Vector2(P4.x,P4.y), Color.green, 100f);
        Debug.DrawLine(new Vector2(P4.x,P4.y),new Vector2(P1.x,P1.y), Color.green, 100f);
    }
}
