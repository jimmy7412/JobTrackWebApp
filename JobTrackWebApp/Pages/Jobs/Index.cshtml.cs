using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobTrackWebApp.Data;
using JobTrackWebApp.Models;

namespace JobTrackWebApp.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly JobTrackWebApp.Data.SchoolContext _context;

        public IndexModel(JobTrackWebApp.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; }

        public async Task OnGetAsync()
        {
            Job = await _context.Job.ToListAsync();
        }
    }
}
