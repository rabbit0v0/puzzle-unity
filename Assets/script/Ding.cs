using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ding : MonoBehaviour
{
    public GameObject people;
    public int state = 0;
    public int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.UpArrow))
        {
            people.transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow))
        {
            people.transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.DownArrow))
        {
            people.transform.Translate(Vector3.down * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.LeftArrow))
        {
            people.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (health == 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void shock()
    {
        if (state == 1)
        {
            health -= 1;
        }
    }

    public void Vallege()
    {
        state = 1;
    }

    public void clear()
    {
        state = 0;
    }
    public int Heal
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
}
