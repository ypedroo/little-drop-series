using System;
using InterfacesxAbstracts.interfaces;
using InterfacesxAbstracts.shared;

namespace InterfacesxAbstracts.models
{
    public class Morty : Base, IPortalGun
    {
        public Morty() : base() { }

        bool isReadyForAdventure = wantsToStartNewAdventure();
        public bool UsesPortalGun()
        {
            Console.WriteLine("Ooh geez Rick i cant use this");
            return false;
        }
    }
}