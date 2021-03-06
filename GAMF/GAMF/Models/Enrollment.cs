using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAMF.Models
{
    public enum Grade { A, B, C, D, F }



    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public Grade Grade { get; set; }


    }
}
