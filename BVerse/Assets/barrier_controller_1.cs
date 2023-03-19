using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_controller_1 : MonoBehaviour
{
    int i = 100;
    Vector3 axis;

    public bool rotateBarrier = false, closebar = false;
    public static barrier_controller_1 instance;
     void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateBarrier)
        {
            transform.RotateAround(transform.position, Vector3.back, 20* Time.deltaTime);
        }
        else if (closebar)
        {
            transform.RotateAround(transform.position, Vector3.forward, 20 * Time.deltaTime);
        }
    }
    
    public void rotate()
    {

        rotateBarrier = true;
        StartCoroutine(wait(4));
        


    }
   
    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        rotateBarrier = false;
        Debug.LogError("time over");
        StartCoroutine(closebarrier());
    }
    IEnumerator closebarrier()
    {
        yield return new WaitForSeconds(10);
        closebar = true;
        yield return new WaitForSeconds(4);
        closebar = false;
    }    
}
