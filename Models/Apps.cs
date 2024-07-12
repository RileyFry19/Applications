using System.ComponentModel.DataAnnotations;

namespace ApplicationsRiley.Models;

public class Apps
{
    [Key]
    public Guid AppId { get; set; }
    
    public string Company { get; set; }
    
    public string Position { get; set; }
    
    public string Location { get; set; }
    
    public DateTime Date { get; set; }
    
    public int Likelihood { get; set; }

    public Apps()
    {

    }

    public Apps(string company, string position, string location, DateTime date, int likelihood)
    {
        Company = company;
        Position = position;
        Location = location;
        Date = date;
        Likelihood = likelihood;
    }
}