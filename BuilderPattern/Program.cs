using BuilderPattern.Builder;
using BuilderPattern.FluentBuilder;
using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var furnitureItems = new List<FurnitureItem>
            {
                new FurnitureItem("Sectional Couch", 55.5, 22.4, 78.6, 35.0),
                new FurnitureItem("Nightstand", 25.0, 12.4, 20.0, 10.0),
                new FurnitureItem("Dining Table", 105.0, 35.4, 100.6, 55.5),
            };

            #region Builder Example

            // Builder Example with Director

            var inventorybuilder = new DailyReportBuilder(furnitureItems);
            var director = new InventoryBuildDirector(inventorybuilder);

            director.BuildCompleteReport();
            var directoryReport = inventorybuilder.GetDailyReport();

            Console.WriteLine(directoryReport.Debug());

            #endregion

            #region Fluent Builder Example

            // We can implement Inventory Builder as Fluent Builder (without director) like below
            // With this approach we can select building features.

            var inventoryFluentBuilder = new DailyReportFluentBuilder(furnitureItems);

            var fluentReport = inventoryFluentBuilder
                .AddTitle()
                .AddDimensions()
                .AddLogistics(DateTime.Now)
                .GetDailyReport();

            Console.WriteLine(fluentReport.Debug());

            #endregion
        }
    }
}
