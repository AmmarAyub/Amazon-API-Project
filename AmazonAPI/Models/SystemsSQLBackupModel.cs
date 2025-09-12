namespace AmazonAPI.Models
{
    public class SystemsSQLBackupModel
    {
        public string Server { get; set; }
        public string database_name { get; set; }
        public DateTime backup_start_date { get; set; }
        public DateTime backup_finish_date { get; set; }
        public int TimeTaken { get; set; }
        public string backup_type { get; set; }
        public decimal SizeInGB { get; set; }
        public string physical_device_name { get; set; }
    }
}
