using System;

namespace BuilderPattern.Builder
{
    public interface IFurnitureInventoryBuilder
    {
        void AddTitle();
        void AddDimensions();
        void AddLogistics(DateTime dateTime);
        InventoryReport GetDailyReport();
    }
}
