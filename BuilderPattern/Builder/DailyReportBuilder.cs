using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern.Builder
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _inventoryReport;
        private IEnumerable<FurnitureItem> _furnitureItems;

        public DailyReportBuilder(IEnumerable<FurnitureItem> furnitureItems)
        {
            Reset();
            _furnitureItems = furnitureItems;
        }

        public void Reset()
        {
            _inventoryReport = new InventoryReport();
        }

        public void AddDimensions()
        {
            _inventoryReport.DimensionsSection = string.Join(Environment.NewLine,
                _furnitureItems.Select(product =>
                $"Product : {product.Name} \nPrice : {product.Price} \n" +
                $"Height : {product.Height} x Width : {product.Width} -> Weight : {product.Weight} lbs\n"));
        }

        public void AddLogistics(DateTime dateTime)
        {
            _inventoryReport.LogisticsSection = $"Report generated on {dateTime}\n\n";
        }

        public void AddTitle()
        {
            _inventoryReport.TitleSection = "*** Daily Inventory Report ***\n\n";
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport inventoryReport = _inventoryReport;
            Reset();

            return inventoryReport;
        }
    }
}
