using System.ComponentModel.DataAnnotations;

namespace DateTimeChecker.Model
{
    public class Date
    {
        [Required(ErrorMessage = "Input data for day is inccorect format")]
        [Range(maximum: 31, minimum: 1)]
        public int Day { get; set; }

        [Required(ErrorMessage = "Input month for month is inccorect format")]
        [Range(maximum: 12, minimum: 1)]
        public int Month { get; set; }

        [Required(ErrorMessage = "Input year for year is inccorect format")]
        [Range(maximum: 3000, minimum: 1000)]
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
