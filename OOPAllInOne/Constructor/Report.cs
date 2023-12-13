namespace Constructor
{
    public enum ReportFormat
    {
        PDF,
        HTML
    }
    public class Report
    {
        public string ExcelFilePath { get; set; }
        public ReportFormat Format { get; set; }

        //public Report()
        //{
        //    Format = ReportFormat.PDF;
        //}

        public Report(string path) : this(path, ReportFormat.PDF)
        {
            //ExcelFilePath = path;
            //Format = ReportFormat.PDF;

        }
        public Report(string path, ReportFormat format)
        {
            ExcelFilePath = path;
            Format = format;
        }
    }

}
