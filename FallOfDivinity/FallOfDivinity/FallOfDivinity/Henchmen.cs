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

                //This enemy targets the player and attempts to "hone in on" him.  Attacks upon contact with player.
    class Henchmen : Enemy
    {
        //fields
        public static int Dammage = Stats.homingEnemyAttack;


        //constructor
        public Henchmen(Player player, Game1 game)
            :base(new Rectangle(0,0,0,0),player, game)
        { }


        //methods
        public void Attack()
        { 
            if(this.Location.Intersects(player.Location))
            {
                player.LoseHealth(Dammage);
            }
        }
    }
}
