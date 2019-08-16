using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Hand : Deck
    {
        // Todo lo que tenia Hand lo tenia Deck, asi que Hand me quedo practicamente vacia, ya que hereda
        // todo de Deck

        // Constructores
        public Hand() : this(new List<CombatCard>()) { }

        public Hand(List<CombatCard> combatCards) : this(combatCards, new List<SpecialCard>()) { }

        public Hand(List<CombatCard> combatCards, List<SpecialCard> specialCards) : base(combatCards, specialCards) {}
    }
}
