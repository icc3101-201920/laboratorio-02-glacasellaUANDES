using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class CombatCard
    {
        //Atributos
        private string name;
        private string type;
        private string effect;
        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard(string name, string type, string effect, int attackPoints, bool hero)
        {
            Name = name;
            Type = type;
            Effect = effect;
            AttackPoints = attackPoints;
            Hero = hero;
        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }   
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
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
