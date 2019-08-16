using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Hand : Deck
    {
        public Hand(List<CombatCard> combatCards, List<SpecialCard> specialCards) : base(combatCards, specialCards)
        {}
    }
}
