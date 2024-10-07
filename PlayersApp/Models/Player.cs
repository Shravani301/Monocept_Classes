using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersApp.Models
{
    internal class Player
    {
        const int DEFAULT_AGE = 16;
        private readonly int _playerId;
        private readonly string _playerName;
        private readonly int _playerAge;

        public Player(int playerId, string playerName)
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = DEFAULT_AGE;
        }
        public Player(int playerId, string playerName, int playerAge) : this(playerId, playerName)
        {
            _playerAge = playerAge>DEFAULT_AGE?playerAge:DEFAULT_AGE;
        }
       
        public static Player WhoIsElder(Player[] players)
        {
            Player maxAgePlayer = players[0];
            int max = players[0]._playerAge;
            for (int i = 1; i < players.Length; i++)
            {
                if (players[i]._playerAge > max)
                {
                    max = players[i]._playerAge;
                    maxAgePlayer = players[i];
                }
            }
            return maxAgePlayer;
        }
        public override string ToString()
        {
            return $"=======================\n" +
                    $"Player ID is: {_playerId}\n" +
                    $"Player Name is:{_playerName}\n" +
                    $"Player Age is: {_playerAge}\n";
        }
    }
}
