﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace FallOfDivinity
{
    abstract class GameObject
    {
        //FIELDS
        protected Game1 game;
        

        //location
        private Rectangle location;

        //property
        public Rectangle Location { get { return location; } set { location = value; } }  

        //constructor
        public GameObject(Rectangle loc, Game1 curGame)
        {
            location = loc;
            game = curGame;
        }


    }
}
