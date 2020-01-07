using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControl : MonoBehaviour
{
    GameObject[] position;
    public GameObject portal;
    List<int> list=new List<int>();
    int count=0;
    int tagnum;
    // Start is called before the first frame update
    void Start()
    {

        position = GameObject.FindGameObjectsWithTag("Portal");
        InvokeRepeating("makingPortal", 0f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void makingPortal()
    { 

        tagnum = UnityEngine.Random.Range(0, 25);
        
        for (int i = 0; i < count; i++)
        {
            if (tagnum == list[i])
            {
                tagnum = UnityEngine.Random.Range(0, 25);
                i = 0;  
            }
        }
        /*int i = 0;
        while(x==array[i])
        {
            x = UnityEngine.Random.Range(0, 99);
            i++;
        }
        */
        Instantiate(portal, new Vector3(position[tagnum].transform.position.x, position[tagnum].transform.position.y, position[tagnum].transform.position.z), Quaternion.identity);
    }
}
