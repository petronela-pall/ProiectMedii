using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectMedii.Data;
using ProiectMedii.Models;

namespace ProiectMedii.Pages.Doctors
{
    public class DetailsModel : PageModel
    {
        private readonly ProiectMedii.Data.ProiectMediiContext _context;

        public DetailsModel(ProiectMedii.Data.ProiectMediiContext context)
        {
            _context = context;
        }

        public Doctor Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doctor = await _context.Doctor.FirstOrDefaultAsync(m => m.ID == id);

            if (Doctor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
