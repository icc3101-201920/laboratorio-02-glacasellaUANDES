using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Deck
    {
        // Atributos de la clae
        private List<CombatCard> combatCards;
        private List<SpecialCard> SpecialCards;

        // Constructores de la clase
        public Deck() : this(new List <CombatCard>()) { }

        public Deck(List<CombatCard> combatCard) : this(combatCard, new List<SpecialCard>()) { }


        public Deck(List<CombatCard> combatCards, List<SpecialCard> specialCards)
        {
            this.combatCards = combatCards;
            this.SpecialCards = specialCards;
        }

        // Getters y setters
        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }

        public List<SpecialCard> SpecialCards1 { get => SpecialCards; set => SpecialCards = value; }

        public void AddCombatCard(CombatCard combatCard) { throw new NotImplementedException(); }

        public void AddSpecialCard(SpecialCard specialCard) { throw new NotImplementedException(); }

        public void DestroyCombatCard(int cardId) { throw new NotImplementedException(); }

        public void DestroySpecialCard(int cardId) { throw new NotImplementedException(); }

        // Metodos de la clase
        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
