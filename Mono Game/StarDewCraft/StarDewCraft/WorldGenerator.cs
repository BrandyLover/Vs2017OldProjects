using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StarDewCraft
{
    
    class WorldGenerator
    {
        
        public Texture2D AtlasTexture { get; set; }
        public int AtlasRows { get; set; }
        public int AtlasColumns { get; set; }
        public GraphicsDevice graphics { get; set; }
        private int currentTexture;
        private int totalTextures;
        private int currentSquare;
        private int totalSquares;
        private int width;
        private int height;
        
        //Inicializa os Tiles
        WorldTile water;
        WorldTile grass;
        WorldTile sand;
        WorldTile rock;
        
        //TODO: Criar o gerador de mundo
        public WorldGenerator(Texture2D atlas, GraphicsDevice device,int atlasColumns, int atlasRows,int gridRows,int gridColumns)
        {
            
            AtlasTexture = atlas;
            AtlasRows = atlasRows;
            AtlasColumns = atlasColumns;
            currentTexture = 0;
            totalTextures = AtlasColumns * AtlasRows;
            currentSquare = 0;
            totalSquares = gridColumns * gridRows;
            graphics = device;
            GetTextures2D();
            InitializeTiles();
            
            
        }
               
        //Cria um Array de Retângulos que estão localizados dentro da textura e que representam texturas individuais no atlas
        private Rectangle[] GetTextures2D()
        {
            Rectangle[] texturesinAtlas = new Rectangle[totalTextures];
            width = AtlasTexture.Width / AtlasColumns;
            height = AtlasTexture.Height / AtlasRows;
            int row;
            int column;
            for (int i = 0; i < totalTextures; i++)
            {
                row = (int)((float)i / (float)AtlasColumns);
                column = i % AtlasColumns;
                texturesinAtlas[i] = new Rectangle(width * column, height * row, width, height);
            }

            return texturesinAtlas;
           
           
        }
        
        //Cria instâncias da classe WorldTile a lista de Blocos(Tiles) que estão disponivéis para se colocar no mundo
        internal void InitializeTiles()
        {
            water = new WorldTile(0);
            grass = new WorldTile(2);
            sand = new WorldTile(1);
            rock = new WorldTile(3);
        }

        //Update Method
        public void Update()
        {
            
            currentTexture++;
            if (currentTexture == totalTextures) currentTexture = 0;
        }

        public void TestDraw(SpriteBatch spriteBatch,Rectangle destinationRectangle)
        {

            spriteBatch.Draw(AtlasTexture,destinationRectangle, GetTextures2D()[currentTexture], Color.White);
        
            
        }

        //Gerador de Seed
        public  Int64 SeedGen(string InputText,Nullable<int> ParamMin,Nullable<int> ParamMax)
        {



            Random rndSeed = new Random();
            int seedadj = rndSeed.Next();

            Int64 InputInt;
            Int64.TryParse(InputText, out InputInt);
            if (!String.IsNullOrEmpty(InputText))
            {
                //Verifica se o InputText continha letra ou número
                if (InputInt == 0) InputInt = InputText.GetHashCode();




                Int64 Seed = InputInt;
                //retorna a Seed
                return Seed;
            }
            //se não tiver nada no input retorna um valor aleatório
            else return Convert.ToInt64(seedadj);


        }

    }
    class WorldTile
    {
        internal int Index;
        internal WorldTile(int atlasIndex)
        {
            Index = atlasIndex;
        }
        
    }
}
