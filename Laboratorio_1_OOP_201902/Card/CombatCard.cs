using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class CombatCard : Card
    {
        // Valores por default de la clase
        private const int DEFAULT_ATTACK_POINTS = 100;
        private const bool DEFAULT_HERO = false;

        //Atributos de la clase
        private int attackPoints;
        private bool hero;

        // Constructores de la clase
        public CombatCard() : this(DEFAULT_NAME) { }

        public CombatCard(string name) : this(name, DEFAULT_TYPE) { }

        public CombatCard(string name, string type) : this(name, type, DEFAULT_EFFECT) { }

        public CombatCard(string name, string type, string effect) : this(name, type, effect, DEFAULT_ATTACK_POINTS) { }

        public CombatCard(string name, string type, string effect, int attackPoints) : this(name, type, effect, attackPoints, DEFAULT_HERO) { }
            
        public CombatCard(string name, string type, string effect, int attackPoints, bool hero) : base(type, effect, name)
        {
            this.attackPoints = attackPoints;
            this.hero = hero;
        }

        // Getters y setters de la clase
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
        {
            get
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
