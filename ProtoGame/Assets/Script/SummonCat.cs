using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCat : MonoBehaviour
{
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
        InvokeRepeating("summoncat", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void summoncat()
    {
        Instantiate(cat, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), Quaternion.identity);
    }
}
