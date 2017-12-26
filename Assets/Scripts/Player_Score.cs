using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

    public float timeLeft = 120;
    public int playerHealth = 3;
    public GameObject timeLeftUI;
    public GameObject playerHealthUI;
    public GameObject textUI;
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left:" + (int)timeLeft);
        playerHealthUI.gameObject.GetComponent<Text>().text = ("Health:" + playerHealth);
        if(timeLeft<0.1f)
        {
            SceneManager.LoadScene("Main");
        }
    }

    void OnTriggerEnter2D (Collider2D trig)
    {
        if(trig.gameObject.name == "Znahar")
        {
            playerHealth += 1;
            Destroy(trig.gameObject);
        }

        if(trig.gameObject.name == "EndLevel")
        {
            textUI.gameObject.GetComponent<Text>().enabled = true;
            Destroy(gameObject);
        }
    }

}
