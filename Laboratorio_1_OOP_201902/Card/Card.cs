using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        // Valores DEFAULT
        protected const string DEFAULT_TYPE = "melee";
        protected const string DEFAULT_EFFECT = "none";
        protected const string DEFAULT_NAME = "Bob";

        // Atributos que todas las cartas comparten
        private string type;
        private string effect;
        private string name;

        // Getters y setters de la clase
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Name { get => name; set => name = value; }

        // Constructores de la clase
        public Card() : this(DEFAULT_TYPE, DEFAULT_EFFECT, DEFAULT_NAME) { }

        public Card(string type) : this(type, DEFAULT_EFFECT, DEFAULT_NAME) { }

        public Card(string type, string effect) : this(type, effect, DEFAULT_NAME) { }

        public Card(string type, string effect, string name)
        {
            this.type = type;
            this.effect = effect;
            this.name = name;
        }
    }
}
