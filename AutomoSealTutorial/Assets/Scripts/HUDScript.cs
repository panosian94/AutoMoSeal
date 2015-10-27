using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    float playerScore = 0;//starting at 0

	void Update () {
        playerScore += Time.deltaTime;//score increases with time
	}

    public void IncreaseScore(int amount)//allows for different kinds of power ups, 43 mins into tutorial
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(playerScore * 100));
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore * 100));//where it'll appear on gamescreen
    }

}
