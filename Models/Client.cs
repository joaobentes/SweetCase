using System.ComponentModel.DataAnnotations.Schema;

namespace SS_Case.Models
{
    public class Client
    {   
        public int ClientID { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("Country")]
        public string CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}