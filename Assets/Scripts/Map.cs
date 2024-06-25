using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public List<Location> locations;
    public GameObject locationButtons;

    
    // Start is called before the first frame update
    void Start()
        
    {
        for(int i = 0; i < locations.Count; i++)
        {
            if(SceneManager.GetActiveScene().name == locations[i].scene)
            {
                locations[i].GetComponent<Button>().enabled = false;

            }
        }
        //locations = new List<Location>();
        //locations = GetComponentsInChildren<Location>();
//        System.DateTime.Now.ToShortTimeString()
//        timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
