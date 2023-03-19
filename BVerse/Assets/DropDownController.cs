using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour
{
    public Dropdown character;
    // Start is called before the first frame update
    void Start()
    {
        onValueChanged();
    }
    public void onValueChanged()
    {
        PlayerPrefs.SetInt("Character", character.value);
        Debug.Log(character.value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
