using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.FluentBuilder
{
    public class DailyReportFluentBuilder : IFurnitureInventoryFluentBuilder
    {
        private InventoryReport _inventoryReport;
        private IEnumerable<FurnitureItem> _furnitureItems;

        public DailyReportFluentBuilder(IEnumerable<FurnitureItem> furnitureItems)
        {
            Reset();
            _furnitureItems = furnitureItems;
        }

        public void Reset()
        {
            _inventoryReport = new InventoryReport();
        }

        public IFurnitureInventoryFluentBuilder AddDimensions()
        {
            _inventoryReport.DimensionsSection = string.Join(Environment.NewLine,
                _furnitureItems.Select(product =>
                $"Product : {product.Name} \nPrice : {product.Price} \n" +
                $"Height : {product.Height} x Width : {product.Width} -> Weight : {product.Weight} lbs\n"));

            return this;
        }

        public IFurnitureInventoryFluentBuilder AddLogistics(DateTime dateTime)
        {
            _inventoryReport.LogisticsSection = $"Report generated on {dateTime}\n\n";

            return this;
        }

        public IFurnitureInventoryFluentBuilder AddTitle()
        {
            _inventoryReport.TitleSection = "*** Daily Inventory Report with Fluent Builder***\n\n";

            return this;
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport inventoryReport = _inventoryReport;
            Reset();

            return inventoryReport;
        }
    }
}
