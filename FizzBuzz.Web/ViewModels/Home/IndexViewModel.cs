using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        [Required,Range(1,100)]
        public int? Number { get; set; }

        public string Result { get; set; }
    }
}