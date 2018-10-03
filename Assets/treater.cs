using UnityEngine;
using System.Collections;

public class treater : MonoBehaviour {

    private int Require = 1;
    private int treaterbonus = 0;
    public GUIText myGuiText;
    public GUIText treatRequire;

    private int counter;

	// Use this for initialization
	void Start () {
        counter = Click.counter;
	}
	
	// Update is called once per frame
	void Update ()
    {

        myGuiText.text = "Candy Count: " + counter;
        treatRequire.text = "Cost: " + Require;

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("treat Click");
            if (counter > Require)
            {
                treaterbonus++;

                Require = Require * 3;

                Debug.Log("treat Click");
            }
        }
        Debug.Log(counter);
        counter = counter + treaterbonus;

	
	}
}
