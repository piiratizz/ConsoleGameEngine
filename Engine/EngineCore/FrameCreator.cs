using System.Collections.Generic;

namespace Engine.EngineCore
{
    public class FrameCreator
    {
        private GridCell[,]? _oldBitmap;
        
        public Frame Create(List<IRenderer> renderers, int height, int width)
        {
            GridCell[,] bitmap = new GridCell[width, height];
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    foreach (var renderer in renderers)
                    {
                        if (renderer.Position.X == i && renderer.Position.Y == j)
                        {
                            if (_oldBitmap != null)
                            {
                                if (renderer.Layer > _oldBitmap[i, j].Cell.Layer)
                                    bitmap[i, j] = new GridCell(renderer.Symbol, renderer.Layer, renderer.Colliding, renderer.Tag);
                                
                                else bitmap[i, j] = _oldBitmap[i,j];
                            }
                            break;
                        }
                        //Bounds
                        if (i == width - 1 || i == 0 || j == height - 1 || j == 0)
                            bitmap[i, j] = new GridCell('#', 0, true, "Wall");
                        
                        else bitmap[i, j] = new GridCell(' ', 0, false);
                    }
                }
            }

            _oldBitmap = bitmap;
            return new Frame(bitmap, width, height);
        }
    }
}