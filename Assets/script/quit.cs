using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        Button button = gameObject.GetComponent<Button>() as Button;
        button.onClick.AddListener(OnClick);
    }


    void OnClick()
    {
        Application.Quit();
    }
}
