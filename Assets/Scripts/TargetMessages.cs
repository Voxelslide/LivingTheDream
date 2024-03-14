using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class TargetMessages : MonoBehaviour
{


	public static TargetMessages TM { get; private set; }
	//Dumpster -> Hopes/Dreams/Creativity -> Poster -> Motivation -> Excuses -> Determination -> Puddle -> Confidence -> Alley -> WakeUP -> Win
	//Target  		Item											 Target    Item					 Target			Item						Target		 Item					 Target		Textbox   Win


	/*
	 TARGETS
	Dumpster          -Dumpster
	Trash bag					-TB
	Poster						-Post
	Sign							-ESign
	Excuse Thumbnail	-EThumb
	Excuse This Tall	-ETall
	Excuse Talent			-ETalent
	Puddle						-Pud
	Alley							-All
	 
	 
	 */

	/*
	Click
	ClickB

	HD
	HDB

	Mot
	MotB

	Det
	DetB

	Con
	ConB
	 */

	public Dictionary<string, string> dumpster = new Dictionary<string, string>();
	public Dictionary<string, string> TB = new Dictionary<string, string>();
	public Dictionary<string, string> Post = new Dictionary<string, string>();
	public Dictionary<string, string> ESign = new Dictionary<string, string>();
	public Dictionary<string, string> EThumb = new Dictionary<string, string>();
	public Dictionary<string, string> ETall = new Dictionary<string, string>();
	public Dictionary<string, string> ETalent = new Dictionary<string, string>();
	public Dictionary<string, string> Pud = new Dictionary<string, string>();
	public Dictionary<string, string> All = new Dictionary<string, string>();

	public void InitializeDictionary()
	{
		dumpster.Add("Click", "You open the familiar dumpster and pull out a bag.\nIt's your hopes and dreams.\nTattered and forgotten, they grace your hands once more.");
		dumpster.Add("ClickB", "This will do.");

		dumpster.Add("HD", "Tempting, but I can't give up on my hopes and dreams again.");
		dumpster.Add("HDB", "Find another way.");

		dumpster.Add("Mot", "Tempting, but I can't throw away my motivation now.");
		dumpster.Add("MotB", "Keep going.");

		dumpster.Add("Det", "No, I won't give up.");
		dumpster.Add("DetB", "Keep pushing forward.");

		dumpster.Add("Con", "There's no way I could toss this!");
		dumpster.Add("ConB", "Not a chance.");
		////////////////////////////
		TB.Add("Click", "An opened trash bag of someone else's aspirations.\nIt's a shame, they look half finished.");
		TB.Add("ClickB", "Keep looking around.");

		TB.Add("HD", "My goals were like this for too long.");
		TB.Add("HDB", "But not anymore.");

		TB.Add("Mot", "A little more motivation could've saved these dreams.");
		TB.Add("MotB", "A shame...");

		TB.Add("Det", "These thrown away dreams are what happens when you always take the easy route.");
		TB.Add("DetB", "Keep moving forward.");

		TB.Add("Con", "Dreams shouldn't end up like this.");
		TB.Add("ConB", "Keep going.");
		////////////////////////////
		Post.Add("Click", "The poster reads: \"Why make your dreams a reality when machines can do it better than you can?! Try our new generative models!\"");
		Post.Add("ClickB", "Sounds demeaning.");

		Post.Add("HD", "If I let some machine do my work for me, how can I be proud of what I've made?");
		Post.Add("HDB", "Go forth with motivation.");

		Post.Add("Mot", "I can do this myself.");
		Post.Add("MotB", "Thank you very much.");

		Post.Add("Det", "I don't need a robot to make things for me.");
		Post.Add("DetB", "I'll make things myself.");

		Post.Add("Con", "Even if it's not perfect, I'd rather accomplish things myself.");
		Post.Add("ConB", "Keep going.");
		////////////////////////////
		ESign.Add("Click", "It's a sign that reads:\n\"EXCUSES\".");
		ESign.Add("ClickB", "Huh.");

		ESign.Add("HD", "It's a sign that reads:\n\"EXCUSES\".");
		ESign.Add("HDB", "Huh.");

		ESign.Add("Mot", "It's a sign that reads:\n\"EXCUSES\".");
		ESign.Add("MotB", "Huh.");

		ESign.Add("Det", "It's a sign that reads:\n\"EXCUSES\".");
		ESign.Add("DetB", "Huh.");

		ESign.Add("Con", "It's a sign that reads:\n\"EXCUSES\".");
		ESign.Add("ConB", "Huh.");
				////////////////////////////
		EThumb.Add("Click", "The caption of this image reads:\n\"Why not take the easy route and just watch what other people have made?\"");
		EThumb.Add("ClickB", "Hmmm...");

		EThumb.Add("HD", "That's... no wait! Can't get distracted!");
		EThumb.Add("HDB", "Keep going.");

		EThumb.Add("Mot", "Sounds like procrastination to me.");
		EThumb.Add("MotB", "Not today.");

		EThumb.Add("Det", "I won't waste my time with this.");
		EThumb.Add("DetB", "Keep going.");

		EThumb.Add("Con", "I don't want to drown out my doubts with this slop. I can face things myself.");
		EThumb.Add("ConB", "I can do hard things.");
		////////////////////////////
		ETall.Add("Click", "The sign reads:\n\"You must be this smart to accomplish your goals!\"");
		ETall.Add("ClickB", "That's a lot of smarts...");

		ETall.Add("HD", "Hmmm...\nI do need knowledge to start...");
		ETall.Add("HDB", "But there has to be more to it.");

		ETall.Add("Mot", "No... It doesn't matter how smart I am now. If I never start, then I'll never realize my goals.");
		ETall.Add("MotB", "I'll put in the work.");

		ETall.Add("Det", "That sign won't stop me, because I can't read!");
		ETall.Add("DetB", "Hehe...");

		ETall.Add("Con", "I'm way smarter than this sign!");
		ETall.Add("ConB", "Nice try.");
		////////////////////////////
		ETalent.Add("Click", "It's a stunning painting. The caption reads:\n\"You'll never be as good as this artist, so why even try?\"");
		ETalent.Add("ClickB", "Harsh...");

		ETalent.Add("HD", "I hope I can be that good.");
		ETalent.Add("HDB", "One day.");

		ETalent.Add("Mot", "The painting is no longer discouraging, it's inspiring!");
		ETalent.Add("MotB", "Keep going.");

		ETalent.Add("Det", "As long as I keep working, I can be as good as the person who made this painting.");
		ETalent.Add("DetB", "Gotta keep going.");

		ETalent.Add("Con", "I don't need to be as \"Talented\" as this artist to be proud of what I've made.");
		ETalent.Add("ConB", "I'll keep working.");
		////////////////////////////
		Pud.Add("Click", "Looking into the puddle, your reflection yells at you:\n\"What brings you back here?\"");
		Pud.Add("ClickB", "\"Oh hey, it's you.\"");

		Pud.Add("HD", "Looking into the puddle, your reflection mocks you:\n\"Oh, those old things! How nostalgic.\"");
		Pud.Add("HDB", "\n\"I'm not giving up on these.\"");

		Pud.Add("Mot", "Looking into the puddle, your reflection speaks slowly to you:\n\"What are you gonna do now? Take the easy way out again?\"");
		Pud.Add("MotB", "\"Not this time. Trust me.\"");

		Pud.Add("Det", "Looking into the puddle, your reflection confesses to you:\n\"Sorry for giving you a hard time, I trust you now to finish what you started.\"");
		Pud.Add("DetB", "\"Thanks.\"");

		Pud.Add("Con", "Looking into the puddle, your reflection smiles at you:\n\"You got this!\"");
		Pud.Add("ConB", "\"You too!\"");
		////////////////////////////
		All.Add("Click", "An unbelievably dark alleyway. You get chills even looking at it.");
		All.Add("ClickB", "Step back.");

		All.Add("HD", "Your hopes and dreams recoil back from the dark alleyway.");
		All.Add("HDB", "Turn back.");

		All.Add("Mot", "You step forward, but feel an immense wave of resistance wash over you.");
		All.Add("MotB", "Step back.");

		All.Add("Det", "You step forward and hold your ground. Looking into the alleyway, you are able to see a bright light at the end of it.");
		All.Add("DetB", "You still lack something.");

		All.Add("Con", "You step towards the alleyway, dreams in hand, motivated, determined, and confident. You reach out towards the light, and it materializes as a glowing bead in your hand.");
		All.Add("ConB", "Aberrate from what is easy.\nWAKE UP");

	}

	public void Awake()
	{
		InitializeDictionary();
	}


	/*
		.Add("Click", "");
		.Add("ClickB", "");

		.Add("HD","");
		.Add("HDB", "");

		.Add("Mot", "");
		.Add("MotB", "");

		.Add("DetB", "");
		.Add("DetB", "");

		.Add("Con", "");
		.Add("ConB", "");
	 */


}
