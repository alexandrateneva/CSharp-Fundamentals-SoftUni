namespace Unit_Testing___Lab.Interfaces
{
    public interface ITarget
    {
        int Health { get; set; }

        int GiveExperience();

        bool IsDead();

        void TakeAttack(int attackPoints);
    }
}
