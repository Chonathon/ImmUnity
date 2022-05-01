using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathogenMotion : MonoBehaviour
{
    // public float accelerationTime = 2f;
    // public float maxSpeed = 5f;
    // private Vector3 movement;
    // private float timeLeft;
    // public float MovementSpeed = 1;
    // // Start is called before the first frame update
    // void Start(){
    //     //rb = GetComponent<PathogenTest> ();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //        timeLeft -= Time.deltaTime;
    //         if(timeLeft <= 0){
    //             movement = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f),0);
    //             timeLeft += accelerationTime;
    //             transform.position += movement* Time.deltaTime * MovementSpeed;
    //         }
    // }

    float count = 0.0f;
    Vector3 startingPoint;
    Vector3 controlPoint;
    Vector3 endingPoint;
    public LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        startingPoint = new Vector3(43,36,0);
        controlPoint = new Vector3(49,39,0);
        endingPoint = new Vector3(54,36,0);
        //lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update(){
        if (count < 1.0f) {
        count += 0.25f *Time.deltaTime;

        Vector3 m1 = Vector3.Lerp( startingPoint, controlPoint, count );
        Vector3 m2 = Vector3.Lerp( controlPoint, endingPoint, count );
        //lr.SetPoints(m2);
        this.transform.position = Vector3.Lerp(m1, m2, count);
        }
        else
        {
        startingPoint = endingPoint;
        controlPoint = new Vector3(Random.Range(endingPoint.x, 42),Random.Range(endingPoint.y, 40),0);
        endingPoint = new Vector3(Random.Range(44, 55),Random.Range(34, 39),0);
        count = 0.0f;
        }  
    }

    public Vector3[] Plot(int steps, Vector3 startingPoint, Vector3 controlPoint, Vector3 endingPoint){
        Vector3[] results = new Vector3[steps];
        float timestep = Time.fixedDeltaTime/Physics2D.velocityIterations;

        return results;
    }
}
