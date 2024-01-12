namespace Engine.EngineCore
{
    public struct GridCell
    {
        public CellType Cell;
                
        public GridCell(char symbol, int layer, bool colliding)
        {
            Cell = new CellType(symbol, layer, colliding);
        }
        public GridCell(char symbol, int layer, bool colliding, string tag)
        {
            Cell = new CellType(symbol, layer, colliding, tag);
        }
    }
}