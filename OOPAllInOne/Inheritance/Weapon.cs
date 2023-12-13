namespace Inheritance
{
    public class Weapon
    {
        public int Weight { get; set; }
        public int HitPoint { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{this.GetType().Name} ile saldırıldı..{HitPoint}  ");
        }
    }

    public class Gun : Weapon
    {
        public int BulletsCount { get; set; }
        public int MaxCharger { get; set; }

        public double Price { get; set; }
        public virtual void ChangeCharger()
        {
            Console.WriteLine($"{GetType().Name} silahının şarjörü değişti!");
        }
    }

    public class Rifle : Gun
    {
        public int Scope { get; set; }
    }

    public class AK47 : Rifle
    {
        //public void ChangeCharger()
        //{
        //    Console.WriteLine($"{GetType().Name} silahı güncellendi ve ateşlemeye hazır!");
        //}

        public override void ChangeCharger()
        {
            Console.WriteLine($"{GetType().Name} silahı güncellendi ve ateşlemeye hazır!");
        }
    }

    public class MKA1 : Rifle
    {

    }

    public class M60 : Rifle
    {

    }


}
