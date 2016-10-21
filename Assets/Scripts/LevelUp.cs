using UnityEngine;
using System.Collections;

public class LevelUp : MonoBehaviour {

    public LevelManager levelManager;
    public bool playerOnFlag;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (playerOnFlag == true && Input.GetKey(KeyCode.Return))
        {
            levelManager.NextLevel();
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerOnFlag = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerOnFlag = false;
        }
    }
    
}
