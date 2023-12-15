namespace MemoryManagement
{
    public class ReportRecorder : IDisposable
    {
        public string Path { get; set; }

        private FileStream fileStream;
        public ReportRecorder(string path)
        {
            Path = path;
            fileStream = new FileStream(path, FileMode.CreateNew);
        }

        ~ReportRecorder()
        {
            fileStream.Dispose();
        }

        public void SaveReport()
        {
            using (fileStream)
            {
                //fileStream.Write()
            }
        }

        public void Dispose()
        {
            fileStream.Dispose();
            GC.WaitForPendingFinalizers();
        }
    }
}
