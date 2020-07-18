using System;
using InterfacesxAbstracts.interfaces;
using InterfacesxAbstracts.shared;

namespace InterfacesxAbstracts.models
{
    public class Morty : Base, IPortalGun
    {
        public Morty() : base() { }


        private static bool WantsToStartNewAdventure()
        {
            return true;
        }
        bool isReadyForAdventure = WantsToStartNewAdventure();

        public bool UsesPortalGun()
        {
            if (isReadyForAdventure)
                Console.WriteLine("Ooh geez Rick i cant use this, but lets go for and adventure");
            return false;
        }
    }
}