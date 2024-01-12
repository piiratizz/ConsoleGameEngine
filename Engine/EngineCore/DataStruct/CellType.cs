namespace Engine.EngineCore
{
    public struct CellType
    {
        public char Symbol;
        public int Layer;
        public bool Colliding;
        public string tag = "Default";
        
        public CellType(char symbol, int layer, bool colliding)
        {
            Symbol = symbol;
            Layer = layer;
            Colliding = colliding;
        }
        
        public CellType(char symbol, int layer, bool colliding, string tag) : this(symbol, layer, colliding)
        {
            this.tag = tag;
        }
    }
}