namespace FirstConsoleApp
{
    public class Building
    {

        public int TotalShopFloorSpace { get; private set; }
        private int FloorCommonArea { get; }
        private int BuildingWidth { get; }
        private int BuildingLength { get; }

        public Building(int floorCommonArea, int buildingWidth, int buildingLength)
        {
            FloorCommonArea = floorCommonArea;
            BuildingWidth = buildingWidth;
            BuildingLength = buildingLength;
        }


        public void CalculateShopFloorSpace()
        {
            TotalShopFloorSpace = ShopFloorSpace();

            int ShopFloorSpace()
            {
                return (BuildingWidth * BuildingLength) - FloorCommonArea;
            }
        }

    }
}
