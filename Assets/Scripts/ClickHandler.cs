using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {
    public GameObject gObject;
    public Sprite newImage;
	public GameObject button;
    private Rigidbody2D rBody;// = gObject.GetComponent<Rigidbody2D>();
	private SpriteRenderer sRend;




    // Use this for initialization
    void Start()
    {
        //rBody = gObject.GetComponent<Rigidbody2D>();




        sRend = gObject.GetComponent<SpriteRenderer>();
       
       // rBody.velocity = new Vector2(5, 0);
    }

    //// Update is called once per frame
    void Update()
    {

    }

    //   //Guaranteed to run at a specific interval
    //   //Physics updates
    //   void FixedUpdated()
    //   {

    //   }




    void OnMouseDown()
    {
        
		if (button.name == "btnRed") {
			sRend.color = Color.red;

		} else if (button.name == "btnGreen") {
			sRend.color = Color.green;

		} else if (button.name == "btnBlue") {
			sRend.color = Color.blue;
		}



        


       // rBody.velocity *= -1;

        // Debug.Log(gObject.name);
    }
}
