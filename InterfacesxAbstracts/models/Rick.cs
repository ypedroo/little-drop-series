using System;
using InterfacesxAbstracts.interfaces;
using InterfacesxAbstracts.shared;

namespace InterfacesxAbstracts.models
{
    public class Rick : Base, IPortalGun
    {
        public Rick() : base(){ }        
        bool ThinksMortyIsStupid = super ThinksMortyIsStupid();

        public bool UsesPortalGun()
        {
            if(ThinksMortyIsStupid)
                Console.WriteLine("Look at me Mortyyy im a demo c# class!!");
            return true;
        }
    }
}