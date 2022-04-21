namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        { 
            _inventory = new Inventory();
        }

        #region property
        public override string LongDescription
        { 
            get
            {
                return $"You are {base.LongDescription}.\n" +
                    $"You are carrying\n" +
                    _inventory.ItemList;
            } 
        }

        public Inventory Inventory
        { get { return _inventory; } }
        #endregion

        public GameObject Locate(string id)
        {
            //return the player object if the id matches with the identifier for the player object
            if(AreYou(id))
            {
                return this;
            }
            //else return the item fetched from the inventory, will return null if the item does not exist
            return _inventory.Fetch(id);
        }
    }
}
