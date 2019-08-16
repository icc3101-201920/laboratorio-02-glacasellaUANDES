using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class CombatCard : Card
    {
        //Atributos
        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard(string name, string type, string effect, int attackPoints, bool hero) : base(type, effect, name)
        {
            AttackPoints = attackPoints;
            Hero = hero;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }
        public bool Hero
        { get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }
    }
}
