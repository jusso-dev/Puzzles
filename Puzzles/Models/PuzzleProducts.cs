using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Puzzles.Models
{
    public class PuzzleProducts
    {
        [Key]
        public int ProductId { get; set; }
        [DisplayName("Type of Puzzle")]
        public string TypeOfPuzzle { get; set; }
        
        public decimal Price { get; set; }
    }
}