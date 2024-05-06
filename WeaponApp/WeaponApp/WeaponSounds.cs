using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponApp
{
    delegate void SondsDelegete();
    internal class WeaponSounds
    {
        public SondsDelegete[] Sounds { get; set; }

        public WeaponSounds()
        {
            Sounds = new SondsDelegete[5]
            {
                PistolSound, FamasSound, M4Sound, MiniGunSound, RPGSound
            };
        }

        public void PistolSound()
        {
            Console.WriteLine("Pew");
        }
        public void FamasSound()
        {
            Console.WriteLine("Pew Pew Pew");
        }
        public void M4Sound()
        {
            Console.WriteLine("Pew Pew Pew Pew Pew");
        }
        public void MiniGunSound()
        {
            Console.WriteLine("Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr Tr");
        }
        public void RPGSound()
        {
            Console.WriteLine("BAM");
        }
    }
}
