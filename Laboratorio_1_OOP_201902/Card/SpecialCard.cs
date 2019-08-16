using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard : Card
    {

        //Atributos de la clase
        private string buffType;

        //Constructores de la clase
        public SpecialCard() : this(DEFAULT_NAME) { }

        public SpecialCard(string name) : this(name, DEFAULT_TYPE) { }

        public SpecialCard(string name, string type) : this(name, type, DEFAULT_EFFECT) { }

        public SpecialCard(string name, string type, string effect) : base(type, effect, name)
        {
            this.buffType = null;
        }

        // Getters y setters de la clase
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
    }
}
