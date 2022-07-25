using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [MinLength(20)]
        public string Description { get; set; }

        [Range(0, 10)]
        public int Priority { get; set; }
    }
}
