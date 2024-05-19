using lab3_THI;

namespace logic
{
    public class DivisionPrizeColculator
    {
        private Division _division;
        public DivisionPrizeColculator(Division division) { _division = division; }

        public float Colculate() {
            float count = 0;
            for (int i = 0; i < _division.weaponList.Count; i++)
            {
                count = count + _division.weaponList[i].Price;
            }
            return count;
        }

    }

    public class DivisionPrizeColculatorFactory {
       
        public static DivisionPrizeColculator CreateDivisionPrizeColculator(Division division) {
            DivisionPrizeColculator divisionPrizeColculator = new DivisionPrizeColculator(division);
            return divisionPrizeColculator;
        }
    }

    public class DivisionFactory
    {
        public static Division CreateDivision()
        {
            //создание объектов

            BladedWeapon blade = new BladedWeapon();
            blade.Name = "Штык-нож";
            blade.Price = 1500;
            blade.Size = 3;
            blade.Lenght = 20;
            blade.HandCount = 2;

            Firearms firearms = new Firearms();
            firearms.Name = "Автомат";
            firearms.Price = 1500;
            firearms.Size = 3;
            firearms.Calibre = 2;
            firearms.NumberRounds = 10000;
            firearms.MaxRounds = 500000;

            HighPrecisionWeapon highPrecisionWeapon = new HighPrecisionWeapon();
            highPrecisionWeapon.Name = "СВ300";
            highPrecisionWeapon.Price = 60000;
            highPrecisionWeapon.Size = 500;
            highPrecisionWeapon.Calibre = 2;
            highPrecisionWeapon.NumberRounds = 10000;
            highPrecisionWeapon.MaxRounds = 500000;
            highPrecisionWeapon.Accuracy = 0.9f;

            //добавление оружия в "подразделение"
            Division division = new Division();
            division.weaponList.Add(blade);
            division.weaponList.Add(firearms);
            division.weaponList.Add(highPrecisionWeapon);
            return division;
        }
    }
}