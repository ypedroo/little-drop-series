namespace InterfacesxAbstracts.shared
{
    public abstract class Base
    {
        public string Name {get; set;}
        public string Gun {get; set;}
        
        public static bool wantsToStartNewAdventure()
        {
            return true;
        }

        public static bool thinksMortyIsStupid()
        {
            return true;
        }
    }
}