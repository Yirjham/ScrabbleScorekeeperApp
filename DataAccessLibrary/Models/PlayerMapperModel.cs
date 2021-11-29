using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PlayerMapperModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        [DisplayName("Games Played")]
        public int GamesPlayed { get; set; }

        [DisplayName("Games Won")]
        public int GamesWon { get; set; }

        [DisplayName("Highest Score")]
        public int HighestScore { get; set; }
    }
}
