namespace NetworkMonitor.Models
{
    public class Traffic
    {
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public long CurrentBytes { get; set; }
    }
}
