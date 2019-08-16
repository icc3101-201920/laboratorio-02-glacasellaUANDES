using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        // Atributos
        private string type;
        private string effect;
        private string name;

        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Name { get => name; set => name = value; }

        // Constructor
        public Card(string type, string effect, string name)
        {
            this.type = type;
            this.effect = effect;
            this.name = name;
        }

    }
}
