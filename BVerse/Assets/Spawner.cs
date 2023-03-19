using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class Spawner : MonoBehaviour
{
   
    // Start is called before the first frame update
    public GameObject Eren;
    public GameObject Remy;
    public GameObject Megan;
    void Start()
    {
        //PhotonNetwork.Instantiate(Playerprefab.name, new Vector3(164.540176f, 91.0800018f, -13.8617039f), Quaternion.identity);
        //PhotonNetwork.Instantiate(Playerprefab.name, new Vector3(Random.Range(163, 170), 91.0800018f, -13.8617039f), Quaternion.identity);
        if (PlayerPrefs.GetInt("Character") == 0)
       {
          PhotonNetwork.Instantiate(Eren.name, new Vector3(16.9920006f, 0.560000002f, 10.1899996f), Quaternion.identity);
       }
        else if (PlayerPrefs.GetInt("Character") == 1)
        {
            PhotonNetwork.Instantiate(Remy.name, new Vector3(26.1800003F, -11f, 153.5F), Quaternion.identity);
            //Vector3(26.1800003, -13.7299995, 153.5)
       }
        else if (PlayerPrefs.GetInt("Character") == 2)
        {
            PhotonNetwork.Instantiate(Megan.name, new Vector3(21.5529995f,0f, 19.3500004f), Quaternion.identity);
            //Vector3(26.1800003, -13.7299995, 153.5)
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
