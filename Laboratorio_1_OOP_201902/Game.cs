using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        public void Play()
        {
            throw new NotImplementedException();
        }





        // Metodos escritos por mi (lo que se pide en el lab)
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int GetWinner()
        {
            if (this.CheckIfEndGame() == false)
            {
                throw new System.InvalidOperationException("Aun no hay un ganador");
            }
            else
            {
                if (players[0].LifePoints == 0)
                {
                    return this.players[1].Id;
                }
                else
                {
                    return this.players[0].Id;
                }
            }
        }
        
    }
}
