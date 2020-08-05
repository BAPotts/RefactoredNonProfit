using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace NonProfit.Models
{
  public class Donation
  {
    public Donation()
    {
      this.Donors = HashSet<DonorDonation>();
    }
    public int DonationId { get; set; }
    public int Money { get; set; }
    public int DonorId { get; set; }
    public virtual Donor Donor { get; set; }
  }
}