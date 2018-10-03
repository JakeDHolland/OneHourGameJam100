using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {


    static public int counter = 0;
    public GUIText myGuiText;

    private int Require = 10;
    private int treaterbonus = 0;
   
    public GUIText treatRequire;

    private int ghostRequire = 300;
    private int ghostbonus = 0;

    public GUIText ghostRequiretxt;

    private int skRequire = 7000;
    private int skbonus = 0;

    public GUIText skRequiretxt;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        
        myGuiText.text = "Candy Count: " + counter;

        if (Input.GetMouseButtonDown(0))
        {
            
            Debug.Log("candy CLick");
            counter++;
        }


      
       

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("treat Click");
            if (counter > Require)
            {
                treaterbonus++;

                Require = Require * 3;
                treatRequire.text = "Cost: " + Require;
                Debug.Log("treat Click");
            }
        }
   
        counter = counter + treaterbonus;


        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("ghost Click");
            if (counter > ghostRequire)
            {
                ghostbonus++;

                ghostRequire = ghostRequire * 2;
                ghostRequiretxt.text = "Cost: " + ghostRequire;
                Debug.Log("treat Click");
            }
        }

        counter = counter + ghostbonus;


        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("SK Click");
            if (counter > skRequire)
            {
                skbonus++;

                skRequire = skRequire * 2;
                skRequiretxt.text = "Cost: " + skRequire;
                Debug.Log("sk Click");
            }
        }

        counter = counter + skbonus;



      

	}
}
