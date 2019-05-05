using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public Ding D;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        D = FindObjectOfType<Ding>();
        t.text = "hp:2";
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "hp:" + D.Heal.ToString();
    }
}
