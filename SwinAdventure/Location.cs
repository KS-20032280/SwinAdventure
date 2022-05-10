namespace SwinAdventure
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public Location(string[] idents, string name, string description) : base(idents, name, description)
        {
            _inventory = new Inventory();
        }

        #region properties
        public Inventory Inventory
        {
            get { return _inventory; }
        }
        public override string FullDescription
        {
            get
            {
                return "You are in the " + Name + ".\n" + base.FullDescription + "\nIn this room you can see:\n" + _inventory.ItemList;
            }
        }
        #endregion

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }
    }
}
