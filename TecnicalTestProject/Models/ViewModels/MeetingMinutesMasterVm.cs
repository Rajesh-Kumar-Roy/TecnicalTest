using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModels
{
    public class MeetingMinutesMasterVm
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field is required.")]
        public DateOnly MeetingDate { get; set; }
        [Required(ErrorMessage = "Field is required.")]
        public TimeOnly MeetingTime { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.PlaceLength)]
        public string Place { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.ClientSideLength)]
        public string ClientSide { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.HostSideLength)]
        public string HostSide { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.AgendaLength)]
        public string Agenda { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.DiscussionLength)]
        public string Discussion { get; set; }
        [Required(ErrorMessage = "Field is required."), MaxLength(ModelLength.DicisionLength)]
        public string Decision { get; set; }
        [Required]
        [ForeignKey("CustomerTypeId")]
        public int CustomerTypeId { get; set; }
        [ValidateNever]
        public CustomerType CustomerType { get; set; }
        [ForeignKey("IndividualCustomerId")]
        public int? IndividualCustomerId { get; set; }
        [ValidateNever]
        public IndividualCustomer IndividualCustomer { get; set; }

        [ForeignKey("CorporateCustomerId")]
        public int? CorporateCustomerId { get; set; }
        [ValidateNever]
        public CorporateCustomer CorporateCustomer { get; set; }
     

        public IList<MeetingMinutesDetails> MeetingMinutesDetails { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CustomerList { get; set; }
        [ValidateNever]
        public IList<CustomerType> CustomerTypeList  { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProductServiceList { get; set; }
        public string SelectedOption { get; set; } = "1";

    }
}
