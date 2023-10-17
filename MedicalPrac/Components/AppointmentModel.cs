using System.ComponentModel.DataAnnotations;


namespace MedicalPrac.Components
{
    public class AppointmentModel
    {
        [Required(ErrorMessage = "Patient Name is required.")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Appointment Date is required.")]
        public DateTime AppointmentDate { get; set; }
    }
}
