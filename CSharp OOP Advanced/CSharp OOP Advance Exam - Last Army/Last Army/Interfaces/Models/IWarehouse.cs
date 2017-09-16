namespace Last_Army.Interfaces.Models
{
    public interface IWareHouse
    {
        void AddAmmunitions(string name, int quantity);

        void EquipArmy(IArmy army);

        bool TryEquipSoldier(ISoldier soldier);
    }
}