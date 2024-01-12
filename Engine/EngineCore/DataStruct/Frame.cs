namespace Engine.EngineCore
{
    public class Frame
    {
        public GridCell[,] Bitmap { get; }
        public int Width { get; }
        public int Height { get; }
            
        public Frame(GridCell[,] bitmap, int width, int height)
        {
            Bitmap = bitmap;
            Height = height;
            Width = width;
        }
    }
}