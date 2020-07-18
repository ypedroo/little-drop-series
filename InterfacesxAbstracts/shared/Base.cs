namespace InterfacesxAbstracts.shared
{
    public abstract class Base
    {
        public string Name { get; set; }
        public string Gun { get; set; }

        public abstract bool WantsToStartNewAdventure();
        public virtual bool ThinksMortyIsStupid()
        {
            return true;
        }
    }
}