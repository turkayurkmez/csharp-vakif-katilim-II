namespace LooselyCoupled
{

    public interface IKiyafet
    {

    }
    public abstract class UstGiyim : IKiyafet { }
    public class Kazak : UstGiyim
    { }
    public class KirmiziKazak : Kazak
    {

    }

    public class Corap : IKiyafet
    {
    }

    public class Ayakkabi : IKiyafet
    {

    }

    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }
}
