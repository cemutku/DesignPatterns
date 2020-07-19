using System;

namespace BuilderPattern.FluentBuilder
{
    public interface IFurnitureInventoryFluentBuilder
    {
        IFurnitureInventoryFluentBuilder AddTitle();
        IFurnitureInventoryFluentBuilder AddDimensions();
        IFurnitureInventoryFluentBuilder AddLogistics(DateTime dateTime);
        InventoryReport GetDailyReport();
    }
}
