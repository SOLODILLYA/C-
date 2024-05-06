using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    internal class WeaponManager
    {
        public WeaponSounds _WeaponSounds { get; set; }
        public string[] _WeaponList { get; set; }

        public WeaponManager() { 
            _WeaponSounds = new WeaponSounds();
            _WeaponList = new string[5] { "Pistol", "Famas", "M4", "Minigun", "RPG"};
        }

        public void MakeSound()
        {
            Console.WriteLine("\n>Choose Weapon\n 1 => Pistol, 2 => Famas, 3 => M4, 4 => Minigun, 5 => RPG");

            if (!int.TryParse(Console.ReadLine(), out int c))
                throw new FormatException("Number of Weapon Format Exception");

            if (c < 1 || c > 5)
                throw new ApplicationException("No such weapon exists");

            string weapon = _WeaponList[c - 1];
            Console.WriteLine($"\n> {weapon}: \n");
            _WeaponSounds.Sounds[c - 1].Invoke();
        }
    }
}
