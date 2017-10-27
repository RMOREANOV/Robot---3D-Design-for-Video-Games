using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    private void Awake()
    {
        Time.timeScale = 0;
        Debug.Log("Pause");
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            Debug.Log("Start");
        }
    }
}
