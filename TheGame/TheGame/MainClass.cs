﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGame
{
    static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Character[] characters = {
				//new Player (),
				//new Enemy (),
				//new Enemy ()
			};


            var engine = new GameEngine();

            foreach (var character in characters)
            {
                engine.Renderer.Draw(character);
            }


        }
    }
}