﻿using System;
using MagicDestroyer.Characters;
using MagicDestroyer.Equipment.Armors;
using MagicDestroyer.Equipment.Weapons;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyer.Characters.Melee
{
    public class Warrior
    {

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string fraction;        
        private string name;


        private Chainlink bodyArmor;
        private Axe Weapon;

        public int AbilityPoints { get; set; }
        public string Fraction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }


        //constructor
        public Warrior ()
        {

        }

        //methods
        public void strike()
        {
            throw new NotImplementedException();
        }

        public void execute()
        {

            throw new NotImplementedException();

        }


        public void skinHarden()
        {
            throw new NotImplementedException();

        }


    }
}
