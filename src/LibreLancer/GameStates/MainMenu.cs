﻿/* The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations
 * under the License.
 * 
 * 
 * The Initial Developer of the Original Code is Callum McGing (mailto:callum.mcging@gmail.com).
 * Portions created by the Initial Developer are Copyright (C) 2013-2016
 * the Initial Developer. All Rights Reserved.
 */
using System;
using System.Collections.Generic;
using LibreLancer.GameData;
namespace LibreLancer
{
	public class MainMenu : GameState
	{
		Texture2D logoOverlay;
		UIManager manager;
		string lastTag = null;
		const double FLYIN_LENGTH = 0.6;
		IntroScene intro;
		Cutscene scene;
		Cursor cur;
		public MainMenu (FreelancerGame g) : base (g)
		{
			g.GameData.LoadHardcodedFiles ();
			g.GameData.PopulateCursors();
			g.MouseVisible = false;

			logoOverlay = g.GameData.GetFreelancerLogo ();

			manager = new UIManager (g);
			manager.MenuButton = g.GameData.GetMenuButton ();
			manager.Elements.Add (new UIMenuButton (manager, new Vector2 (-0.65f, 0.40f), "GAMEPLAY DEMO", "gameplay"));
			manager.Elements.Add (new UIMenuButton (manager, new Vector2 (-0.65f, 0.15f), "SYSTEM VIEWER", "system"));
			manager.Elements.Add (new UIMenuButton (manager, new Vector2 (-0.65f, -0.1f), "MULTIPLAYER"));
			manager.Elements.Add (new UIMenuButton (manager, new Vector2 (-0.65f, -0.35f), "OPTIONS"));
			manager.Elements.Add (new UIMenuButton (manager, new Vector2 (-0.65f, -0.6f), "EXIT", "exit"));
			manager.FlyInAll(FLYIN_LENGTH, 0.05);
			manager.Clicked += (tag) => lastTag = tag;

			intro = g.GameData.GetIntroScene();
			scene = new Cutscene(intro.Script, Game);
			scene.Update(TimeSpan.FromSeconds(1f / 60f)); //Do all the setup events - smoother entrance
			g.Sound.PlayMusic(intro.Music);

			cur = g.ResourceManager.GetCursor("arrow");
			GC.Collect(); //GC before showing
		}


		int frames = 0;
		int dframes = 0;
		public override void Update (TimeSpan delta)
		{
			//Don't want the big lag at the start
			if (frames == 0)
			{
				frames = 1;
				return;
			}
			scene.Update(delta);
			manager.Update (delta);
			if (lastTag == "gameplay")
			{
				Game.ChangeState(new DemoGameplay(Game));
			}
			if (lastTag == "system") {
				Game.ChangeState (new DemoSystemView (Game));
			}
			if (lastTag == "exit") {
				Game.Exit ();
			}
			lastTag = null;
		}

		public override void Draw (TimeSpan delta)
		{
			//Make sure delta time is normal
			if (dframes == 0)
			{
				dframes = 1;
				return;
			}
			//TODO: Draw background THN
			scene.Draw();
			//UI Background
			Game.Renderer2D.Start (Game.Width, Game.Height);
			Game.Renderer2D.DrawImageStretched (logoOverlay, new Rectangle (0, 0, Game.Width, Game.Height), Color4.White, true);
			Game.Renderer2D.Finish ();
			//buttons
			manager.Draw();
			//Cursor
			Game.Renderer2D.Start(Game.Width, Game.Height);
			cur.Draw(Game.Renderer2D, Game.Mouse);
			Game.Renderer2D.Finish();
		}
	}
}

