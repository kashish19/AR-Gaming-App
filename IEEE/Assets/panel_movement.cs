using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_movement : MonoBehaviour {
	bool panel_off=false;
	bool button_off=true;
	bool main_panel_off=false;

	public GameObject panel_character;
	public GameObject panel_dress;
	public GameObject panel_move;

	public GameObject button_dress;
	public GameObject button_mov;
	public GameObject button_character;

	public GameObject main_panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// for hiding/showing main panel on click/again click
	public void main_panell()
	{
		main_panel_off=!main_panel_off;
		main_panel.SetActive(main_panel_off);

	}

		public void panel_mov()
	{
		//for hiding/showing movement panel on click/again click 
		panel_off=!panel_off;
		panel_move.SetActive (panel_off);

		//hide/show movement and character button on clicking on movement button
		button_off = !button_off;
		button_dress.SetActive (button_off);
		button_character.SetActive (button_off);
	}

		public void panel_char()
	{
		//for hiding/showing character panel on click/again click
		panel_off=!panel_off;
		panel_character.SetActive (panel_off);

		//hide/show movement and dress button on clicking on character button
		button_off = !button_off;
		button_mov.SetActive (button_off);
		button_dress.SetActive (button_off);
	}

	//for hiding/showing dress panel on click/again click
	public void panel_dres()
	{
		//for hiding/showing movement panel on click/again click 
		panel_off=!panel_off;
		panel_dress.SetActive (panel_off);

		//hide/show movement and character button on clicking on dress button
		button_off = !button_off;
		button_character.SetActive (button_off);
		button_mov.SetActive (button_off);
	}
}
