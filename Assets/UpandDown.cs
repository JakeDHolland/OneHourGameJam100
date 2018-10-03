using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpandDown : MonoBehaviour {

    private int counter = 0;
    private bool reverse = false;
    public GameObject bullet;
    private int shoot = 0;


    private int jake = 0;

    public GUIText myGuiText;
    
   
   //private int score = 0;
    
	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
       shoot = Random.Range(0, 100);
       Debug.Log(shoot);
       if (shoot == 40 || shoot == 42 || shoot == 41 )
       {
           jake++;
           myGuiText.text = "score" + jake; 
           Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
       }

        if (reverse == true)
        {
            Vector3 position = this.transform.position;
            position.y = position.y - 0.1f;
            this.transform.position = position;
            counter++;
        }
        if (reverse == false)
        {
            Vector3 position = this.transform.position;
            position.y = position.y + 0.1f;
            this.transform.position = position;
            counter++;
        }

        if (counter > 80 && reverse == false)
        {
            reverse = true;
            counter = 0;
        }

        if (counter > 80 && reverse == true)
        {
            reverse = false;
            counter = 0;
        }

	}
}
