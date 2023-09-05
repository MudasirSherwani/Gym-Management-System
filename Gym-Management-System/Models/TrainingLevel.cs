﻿using Gym_Management_System.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymMGT.Models
{
    public class TrainingLevel
    {
        [Key]
        public int TrainingLevelID { get; set; }
        public string TrainingLevelName { get; set; }
        public virtual ICollection<GymTrainee> GymTrainees { get; set; }
    }
}
