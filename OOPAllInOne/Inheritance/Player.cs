namespace Inheritance
{
    public class Player
    {
        public string Name { get; set; }
        public bool IsCounterTeam { get; set; }

        public Weapon Weapon { get; set; }

        public void Attack()
        {
            Weapon.Attack();
        }
        public void ChangeCharger()
        {
            if (Weapon is Gun)
            {
                ((Gun)Weapon).ChangeCharger();
            }
        }
    }
}
