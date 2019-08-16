using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        // Valores DEFAULT
        private const int DEFAULT_PLAYER_ID = 1;
        private const string DEFAULT_SPECIALCARDS_BUFFTYPE = null;

        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }



        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }

        

        //Metodos
        public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            throw new NotImplementedException();
        }









        // METODOS ESCRITOS POR MI (LO QUE SE PIDE EN EL LAB)

        public void AddCombatCard(int playerId, CombatCard combatCard)
        {
            // Primero, obtenemos el tipo de la carta
            string type = combatCard.Type;
            // Dependiendo del tipo, la agregamos a la lista de cartas del jugador correspondiente
            if (type == "melee")
            {
                this.meleeCards[playerId].Add(combatCard);
            }
            else if (type == "rangeCards")
            {
                this.rangeCards[playerId].Add(combatCard);
            }
            else
            {
                this.longRangeCards[playerId].Add(combatCard);
            }
            return;
        }

        // Como se pedia dejar el playerId y el buffType como parametros opcionales,
        // escribi varios metodos AddSpecialCard que se llaman entre si, como si
        // concatenara constructores
        public void AddSpecialCard(SpecialCard specialCard)
        {
            AddSpecialCard(specialCard, DEFAULT_PLAYER_ID);
            return;
        }

        public void AddSpecialCard(SpecialCard specialCard, int playerId)
        {
            AddSpecialCard(specialCard, playerId, DEFAULT_SPECIALCARDS_BUFFTYPE);
            return;
        }

        public void AddSpecialCard(SpecialCard specialCard, int playerId, string buffType)
        {
            // Primero, obtenemos el tipo de la carta
            string type = specialCard.Type;

            // Dependiendo del tipo, la agregamos a la lista de cartas del jugador correspondiente
            // Unicamente agregamos la carta si vemos que la posicion donde deberia estar la carta del 
            // jugador correspondiente esta vacia. Sino, tiramos un error.
            if (type == "specialMelee")
            {
                if (specialMeleeCards[playerId] == null)
                {
                    specialMeleeCards[playerId] = specialCard;
                }
                else
                {
                    throw new System.InvalidOperationException("El jugador ya tiene una specialMeleeCard");
                }
            }
            else if (type == "specialRange")
            {
                if (specialRangeCards[playerId] == null)
                {
                    specialRangeCards[playerId] = specialCard;
                }
                else
                {
                    throw new System.InvalidOperationException("El jugador ya tiene una specialRangeCard");
                }
            }
            else
            {
                if (specialLongRangeCards[playerId] == null)
                {
                    specialLongRangeCards[playerId] = specialCard;
                }
                else
                {
                    throw new System.InvalidOperationException("El jugador ya tiene una specialLongRangeCard");
                }
            }
        }

        public void DestroyCombatCard(int playerId)
        {
            // Usamos Clear para limpiar todas las listas del jugador
            this.meleeCards[playerId].Clear();
            this.rangeCards[playerId].Clear();
            this.longRangeCards[playerId].Clear();
            return;
        }

        public void DestroySpecialCard(int playerId)
        {
            // Para destruir, entiendo que se debe poner el valor dentro del array en null
            // no haria falta hacerle resize al mismo
            this.specialMeleeCards[playerId] = null;
            this.specialRangeCards[playerId] = null;
            this.specialLongRangeCards[playerId] = null;
            return;
        }

        public int[] GetMeleeAttackPoints()
        {
            // Definimos contadores para los puntos de ataque de ambos jugadores
            int contadorJ0 = 0;
            int contadorJ1 = 0;

            // Recorremos las cartas de cada jugador y vamos sumando los puntos de ataque
            for (int i = 0; i < meleeCards[0].Count; i++)
            {
                contadorJ0 += meleeCards[0][i].AttackPoints;
            }

            for (int i = 0; i < meleeCards[1].Count; i++)
            {
                contadorJ1 += meleeCards[1][i].AttackPoints;
            }

            int[] result = new int[2] { contadorJ0, contadorJ1 };
            return result;
        }

        public int[] GetRangeAttackPoints()
        {
            // Definimos contadores para los puntos de ataque de ambos jugadores
            int contadorJ0 = 0;
            int contadorJ1 = 0;

            // Recorremos las cartas de cada jugador y vamos sumando los puntos de ataque
            for (int i = 0; i < rangeCards[0].Count; i++)
            {
                contadorJ0 += rangeCards[0][i].AttackPoints;
            }

            for (int i = 0; i < rangeCards[1].Count; i++)
            {
                contadorJ1 += rangeCards[1][i].AttackPoints;
            }

            int[] result = new int[2] { contadorJ0, contadorJ1 };
            return result;
        }

        public int[] GetLongRangeAttackPoints()
        {
            // Definimos contadores para los puntos de ataque de ambos jugadores
            int contadorJ0 = 0;
            int contadorJ1 = 0;

            // Recorremos las cartas de cada jugador y vamos sumando los puntos de ataque
            for (int i = 0; i < longRangeCards[0].Count; i++)
            {
                contadorJ0 += longRangeCards[0][i].AttackPoints;
            }

            for (int i = 0; i < longRangeCards[1].Count; i++)
            {
                contadorJ1 += longRangeCards[1][i].AttackPoints;
            }

            int[] result = new int[2] { contadorJ0, contadorJ1 };
            return result;
        }

    }
}
