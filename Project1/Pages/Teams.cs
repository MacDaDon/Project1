namespace Project1.Pages
{
    public class Teams
    {
 
        public int TeamId { get; set; }
        public string? TeamName { get; set; }
        public string? Score { get; set; }

     
        public string? Verses { get; set; }
        public enum teams
        {
            Liverpool,
            ManU,
            Mancity,
            Chiefs,
        }
     }
}
