using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    private float t;
    private Vector2 objectPosition;
    
    [SerializeField]
    private float speedModifier;
    private bool coroutineAllowed;

    [SerializeField]
    private BoundingBox BoundingBox;
    
    private Vector2 a;
    private Vector2 b;
    private Vector2 c;
    private Vector2 d;

    private Vector2 gizmosPosition;
    // Start is called before the first frame update
    void Start(){
        t = 0f;
        speedModifier = 0.5f;
        coroutineAllowed = true;

        a = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        b = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        c = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        d = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
    }

    // Update is called once per frame
    void Update(){
        if (coroutineAllowed){
            StartCoroutine(GoByTheRoute(BoundingBox));
        }
    }

    private IEnumerator GoByTheRoute(BoundingBox BoundingBox){
        coroutineAllowed = false;

        // Vector2 p4 = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        // Vector2 p5 = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        // Debug.DrawLine(new Vector2(p4.x,p4.y),new Vector2(p5.x,p5.y), Color.red, 100f);

        while(t < 1){
            t += Time.deltaTime * speedModifier;
            //objectPosition = Mathf.Pow(1 - t, 3) * p0 + 3 * Mathf.Pow(1 - t, 2) * t * p1 + 3 * (1 - t) * Mathf.Pow(t, 2) * p2 + Mathf.Pow(t, 3) * p3;
            objectPosition = CubicCurve(a,b,c,d,t);
            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        a = d;
        b = new Vector2(d.x,Random.Range(d.y,LineEquation(BoundingBox.P3.x,c,d)));

        c = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        d = new Vector2(Random.Range(BoundingBox.P1.x,BoundingBox.P3.x),Random.Range(BoundingBox.P1.y,BoundingBox.P3.y));
        t = 0f;

        


        coroutineAllowed = true;
    }

    private float LineEquation(float x, Vector2 startPos, Vector2 endPos){
        float y;
        Vector2 dir = endPos - startPos;
        float slope = dir.y / dir.x;
        return y= startPos.y - slope * startPos.x;
    }

    private void OnDrawGizmos(){
        for(float t = 0; t <= 1; t += 0.025f){
            gizmosPosition = CubicCurve(a,b,c,d,t);
            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector2(a.x, a.y), new Vector2(b.x, b.y));
        Gizmos.DrawLine(new Vector2(c.x, c.y), new Vector2(d.x, d.y));
    }

    public static Vector2 Lerp(Vector2 a, Vector2 b, float t){
        return a + (b-a)*t;
    }

    public static Vector2 QuadraticCurve(Vector2 a, Vector2 b, Vector2 c, float t){
        Vector2 p0 = Lerp(a, b, t);
        Vector2 p1 = Lerp(b, c, t);
        return Lerp(p0, p1, t);
    }

    public static Vector2 CubicCurve(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t){
        Vector2 p0 = QuadraticCurve(a, b, c, t);
        Vector2 p1 = QuadraticCurve(b, c, d, t);
        return Lerp(p0, p1, t);
    }
}
    