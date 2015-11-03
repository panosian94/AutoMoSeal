using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

    HUDScript hud;

    float speed = .5f;
    private Vector3 pos;
    //private float length;

    void Start()
    {
        pos = this.transform.position;
        //length = GetComponent<Renderer>().bounds.size.z;
    }
    void Update()
    {
        pos.z -= speed;
       this.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("other.tag: " + other.tag);

        if (other.tag == "Player")
        {
            hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
            hud.IncreaseScore(50000);
            //Debug.Log("playerScore: " + hud.playerScore);
            Destroy(this.gameObject);
        }
    }

}
