using InterfacesxAbstracts.interfaces;
using InterfacesxAbstracts.shared;

namespace InterfacesxAbstracts.models
{
    public class Rick : Base, IPortalGun
    {
        public Rick() : base(){ }        
        bool isReadyForAdventure = wantsToStartNewAdventure();

        public bool UsesPortalGun()
        {
            return true;
        }
    }
}