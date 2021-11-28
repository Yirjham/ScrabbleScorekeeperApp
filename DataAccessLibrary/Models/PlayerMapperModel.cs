using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PlayerMapperModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int HighestScore { get; set; }
    }
}
