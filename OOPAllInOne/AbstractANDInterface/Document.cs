namespace AbstractANDInterface
{
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public string Owner { get; set; }
        public string Title { get; set; }
        public void Copy(string from, string to)
        {

        }
        public void Move(string from, string to)
        {

        }
        public abstract void Load();
        public abstract void Save();
        // public abstract void Print();



    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            Console.WriteLine("PDF dosyası açıldı");
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            Console.WriteLine("PDF dosyası kaydedildi");

        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            //ayarlar...
            document.Print();
        }
    }
}
