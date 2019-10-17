using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button but;
    public GameObject canvas;
    public GameObject button;

    public int action;
    // Start is called before the first frame update
    void Start()
    {

        Button button = but.GetComponent<Button>();
        button.onClick.AddListener(Up);
       // Button button = but.GetComponent<Button>();
       // button.onClick.AddListener(Down);
       // Button button = but.GetComponent<Button>();
       // button.onClick.AddListener(Fire);
    }

    // Update is called once per frame
    void Update()
    {
        if (!but.isActiveAndEnabled)
        {
            action = 0;
        }
    }
    void Up()
    {
        action = 1;
    }
    void Down()
    {
        action = 2;
    }
    void Fire()
    {
        action = 3;
    }
    void Up2()
    {
        action = 1;
    }
    void Down2()
    {
        action = 2;
    }
    void Fire2()
    {
        action = 3;
    }
}
