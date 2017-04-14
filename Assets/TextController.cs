using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

	public Text text;

	// Use this for initialization
	void Start ()
	{
		text.text = "Hello World";	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "After a long journey you finally arrive at your new home.\n"
			+ "It's a prison cell. Hurray!\n"
			+ "There are some dirty sheets on the bed, a locked door and a mirror on the wall.\n\n"
			+ "Press S to view Sheets, M to view Mirror and D to view Door."; 
		}
	}
}
