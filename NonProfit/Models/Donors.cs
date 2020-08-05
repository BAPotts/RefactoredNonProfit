using System.Collections.Generic;

namespace NonProfit.Models
{
  public class Donor 
  {
    public Donor()
    {
      this.Donations = new HashSet<DonorDonation>();
    }
    public ICollection<DonorDonation> Donations { get; set;}
    public int DonorId { get; set;}
    public string Name { get; set;}
    // public virtual ICollection<Donation> Donations {get;set;}
  }
}