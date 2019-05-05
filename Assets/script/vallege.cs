using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vallege : MonoBehaviour
{
    public Ding D;
    // Start is called before the first frame update
    void Start()
    {
        D = FindObjectOfType<Ding>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        D.Vallege();
    }
}
