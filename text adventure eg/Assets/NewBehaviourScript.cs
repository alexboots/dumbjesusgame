using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // So you can access public Text
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public Text text;
	private enum States { 
		back_stage,
		stage, 
		approach_bread, 
		walk_water, 
		wine_water, 
		semi_convinced, 
		heal_penn, 
		heal_teller, 
		made_world_better 
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.back_stage;
	}

	// Update is called once per frame
	void Update () {
		if      (myState == States.back_stage) 		  { back_stage (); } 
		else if (myState == States.stage) 			  { stage (); } 
		else if (myState == States.approach_bread)    { approach_bread (); } 
		else if (myState == States.walk_water) 		  { approach_water (); } 
		else if (myState == States.wine_water) 		  { approach_glass (); } 
		else if (myState == States.semi_convinced) 	  { semi_convinced (); } 
		else if (myState == States.heal_penn) 		  { heal_penn (); } 
		else if (myState == States.heal_teller) 	  { heal_teller (); } 
		else if (myState == States.made_world_better) { made_world_better (); }
	}

	void back_stage () {
		text.text = "You came back to save humanity from itself once again.\n" + 
			"After many failed attempts, you know that these upcoming miracles will be seen by enough eyes to make a difference.\n\n" +
			"Press `S` to walk on the Stage of Penn and Tellers 'Fool Me'.";

		if (Input.GetKeyDown(KeyCode.S)) { stage (); }
	}

	void stage () {
		myState = States.stage;

		text.text = "You stand on stage with preselected props out in front of your miracle makings self.\n\n" +
			"Press B to approach Bread or W to appraoch the vat of Water, or G to approach the glass of water.";

		if (Input.GetKeyDown(KeyCode.B))      { approach_bread (); } 
		else if (Input.GetKeyDown(KeyCode.W)) { approach_water (); } 
		else if (Input.GetKeyDown(KeyCode.G)) { approach_glass (); }
	}

	void approach_bread () {
		myState = States.approach_bread;

		text.text = "You turn one loaf into many. Penn makes a quip about it 'like being at olive garden'. Teller looks unphased.\n\n" +
			"Press S to return to Stage center.";

		if (Input.GetKeyDown(KeyCode.S)) { stage (); } 
	}

	void approach_water () {
		myState = States.walk_water;

		text.text = "You approach the Vat of water. You delicately take off your sandles and hop ontop of it, wandering out splish splashing like only Jesus can.\n" +
			"Teller looks at Penn and shakes his head disapprovingly.\n\n" +
			"Press S to return to stage center.";

		if (Input.GetKeyDown(KeyCode.S)) { stage (); } 
	}

	void approach_glass () {
		myState = States.wine_water;

		text.text = "You Approach the glass and declare 'behold' and fill it up with water from the Vat beside you. With a wave of your hand its transformed into the finest Pinot money can buy." +
			"You walk to Penn and hand it to him and he is impressed - you're finally getting through!\n\n" +
			"Press C to figure out how to convince them of your miraculous nature.";

		if (Input.GetKeyDown(KeyCode.C)) { semi_convinced (); } 
	}

	void semi_convinced () {
		myState = States.semi_convinced;

		text.text = "You realize you need to cast a mircle healing spell upon them personally to convince.\n" +
			"Press P to heal Penn or T to heal Teller";

		if (Input.GetKeyDown(KeyCode.P)) { heal_penn (); } 
		if (Input.GetKeyDown(KeyCode.T)) { heal_teller (); } 
	}

	void heal_penn () {
		myState = States.heal_penn;

		text.text = "You lay your hands on Penn's to cure his sort of annoying demeanour and to your surprize\n" +
			"your hands are shot back off of him like you touched lightneing! You try and play it off like it was on purpose," + 
			"wondering if he is actually satan. \n\n" +
			"Press T to try and heal Teller";

		if (Input.GetKeyDown(KeyCode.T)) { heal_teller (); }
	}

	void heal_teller () {
		myState = States.heal_teller;

		text.text = "You lay your hands on Tellers and command him to speak! HE REGAINS THE GIFT OF SPEACH.\n" +
			"Thouroughly convinced your a miracle worker, they say not only have you fooled them but you are in fact Jesus!" +
			"Since the whole viewing audience believes them you can now go forth and cure the world of all that is wrong!!\n\n" +
			"Hit Space to continue.";


		if (Input.GetKeyDown(KeyCode.Space)) { made_world_better (); }
	}

	void made_world_better () {
		myState = States.made_world_better;

		text.text = "Someone uploaded the clip to YouTube and so you were able to wander around and convince " + 
			"everyone to be nice to each other, saving the world and also everyone stopped poluting and stuff like that, the end.";
		
	}
}