using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Gym_Management_System.Models
{
    public class GymTrainee
    {

        [Key]
        [Column(TypeName = "int")]
        public int TraineeId { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("First Name")]
        public String FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Last Name")]
        public String LastName { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contact No")]
        public String ContactNo { get; set; } = "0";


        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Height")]
        public String Height { get; set; } = "0";



        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Weight")]
        public int Weight { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gender")]
        public String Gender { get; set; } = "Male";

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Address")]
        public String Address { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        public DateTime CreationDate { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
