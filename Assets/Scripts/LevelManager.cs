using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    private PlayerMovement player;

    public string levelToLoad;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
        player = FindObjectOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
    }

    public void NextLevel()
    {
        Debug.Log("Level Up!");
        Application.LoadLevel(levelToLoad);
    }
}
