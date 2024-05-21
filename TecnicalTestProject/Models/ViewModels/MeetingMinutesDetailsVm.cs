using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Model.ViewModels
{
    public class MeetingMinutesDetailsVm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public int Quantity { get; set; }

        [Required, ForeignKey("ProductsServiceId")]
        public int ProductsServiceId { get; set; }

        public int MeetingMinutesMasterId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProductServiceList { get; set; }
    }
}
