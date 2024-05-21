using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Model.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class MeetingMinutesMaster
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Field is required.")]
        public DateOnly MeetingDate{get;set;}
        [Required(ErrorMessage = "Field is required.")]
        public TimeOnly MeetingTime{get;set; }
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
        
        [ForeignKey("IndividualCustomerId")]
        public int? IndividualCustomerId { get; set; }
        [ValidateNever]
        public IndividualCustomer IndividualCustomer { get; set; }

        [ForeignKey("CorporateCustomerId")]
        public int? CorporateCustomerId { get; set; }
        [ValidateNever]
        public CorporateCustomer CorporateCustomer { get; set; }
        [ForeignKey("CustomerTypeId")]
        public int CustomerTypeId { get; set; }
        [ValidateNever]
        public CustomerType CustomerType { get; set; }
        public IList<MeetingMinutesDetails> MeetingMinutesDetails { get; set; }
    }

    public class MeetingMinutesDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public int Quantity { get; set; }

        [Required,ForeignKey("ProductsServiceId")]
        public int ProductsServiceId { get; set; }
        [ValidateNever]
        public ProductsService ProductsService { get; set; }

        public int MeetingMinutesMasterId { get; set; }
        [ValidateNever]
        public MeetingMinutesMaster MeetingMinutesMaster { get; set; }




    }

    public class MasterDetailsRetrunModel
    {
        public int Id { get; set; }
        [NotMapped,ValidateNever]
        public int Sl { get; set; }
        public string Name { get; set; }
        public int Unit { get; set; }
        public int Quantity { get; set; }
        public int MeetingMinutesMasterId { get; set; }
    }
}
