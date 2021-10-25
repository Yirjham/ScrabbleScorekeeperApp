using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScorekeeperUniversalLibrary;
using ScorekeeperUniversalLibrary.Models;

namespace RazorPagesUI.Pages
{
    public class CreatePlayerModel : PageModel
    {
        [BindProperty]
        public PlayerModel Player { get; set; }
        public void OnGet()
        {
        }
    }
}
