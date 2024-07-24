using System.ComponentModel.DataAnnotations;

namespace KSHIFSYSTEM.Models
{
    public class TarshehBook
    {
        public int ID { get; set; }
        [Required]
        public int  BookNo { get; set; }
        public DateTime? BookDate { get; set; }
        public int? HayaBookNo { get; set; }
        public DateTime? HayaBookDate { get; set; } = DateTime.Now.Date;
        public string? JehaName { get; set; }
        public DateTime? KshefDate { get; set; }
        public string? PlaceNo { get; set; }
        public string? MokataNO { get; set; }
        public int?  AddadAlkhobraa { get; set; }
        public int? AlwasilNo { get; set; }
        public DateTime? AlwasilDate { get;set; }
       
        public string? city { get; set; }
        public int? WasilNoM { get; set; }
        public DateTime? WasilDateM { get; set; }
        public int? WasilNoP { get; set; }
        public DateTime? WasilDateP { get; set; }
        public string? KshifType { get; set; }
        public string? SpecaialName1 { get; set; }
        public string? SpecaialName2 { get; set; }
        public string? SpecaialName3 { get; set; }
        public string? SpecaialName4 { get; set; }
        public string? SpecaialName5 { get; set; }
        public string? SpecaialName6 { get; set; }
        public string? SpecaialName7 { get; set; }
        public string? SpecaialName8 { get; set; }
        public string? SpecaialName9 { get; set; }
        public string? SpecaialName10{ get; set; }
        public string? SpecaialName11 { get; set; }

        public string? SpecaialName12 { get; set; }

        public string? SpecaialName13 { get; set; }

        public string? SpecaialName14 { get; set; }

        public string? SpecaialName15 { get; set; }
        public string? SpecaialName16 { get; set; }

        public string? SpecaialTitle1 { get; set; }
        public string? SpecaialTitle2 { get; set; }
        public string? SpecaialTitle3 { get; set; }
        public string? SpecaialTitle4 { get; set; }
        public string? SpecaialTitle5 { get; set; }
        public string? SpecaialTitle6 { get; set; }
        public string? SpecaialTitle7 { get; set; }
        public string? SpecaialTitle8 { get; set; }
        public string? SpecaialTitle9 { get; set; }
        public string? SpecaialTitle10 { get; set; }
        public string? SpecaialTitle11 { get; set; }

        public string? SpecaialTitle12 { get; set; }

        public string? SpecaialTitle13 { get; set; }

        public string? SpecaialTitle14 { get; set; }

        public string? SpecaialTitle15 { get; set; }
        public string? SpecaialTitle16 { get; set; }



        public string? KshifResult { get; set; }
        public string? KshifResultPicture { get; set; }
        public DateTime? Update_Date { get; set; } = DateTime.Now;
        public string? UserName { get; set; }
    }
}
