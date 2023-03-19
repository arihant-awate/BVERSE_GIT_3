using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class barrier_controller : MonoBehaviour
{
    public InputField uid;
    public InputField name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void rotatecall()
    {
        if (uid.text == "1234")
        {
            barrier_controller_1.instance.rotate();
            uid.text = "";
            name.text = "";
        }
        else
        {
            uid.text = "Wrong UID, try again";
        }
    }
}
