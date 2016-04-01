namespace BigMani.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Models;
    using BigMani.Controllers;

    class CommandProcessor
    {
        public AirConditionerTestingEngine vroom;

        public CommandProcessor(AirConditionerTestingEngine vrooom)
        {
            this.vroom = vrooom;
        }

        public void DoMagic()
        {
            var magic = vroom.magic;
            try
            {
                switch (magic.Name)
                {
                    case "RegisterStationaryAirConditioner":
                        vroom.ValidateParametersCount(magic, 4);
                        RegisterStationaryAirConditioner(
                            magic.Parameters[0],
                            magic.Parameters[1],
                            int.Parse(magic.Parameters[2]),
                            magic.Parameters[3]);
                        break;
                    case "RegisterCarAirConditioner":
                        vroom.ValidateParametersCount(magic, 3);
                        RegisterCarAirConditioner(
                            magic.Parameters[0],
                            magic.Parameters[1],
                            int.Parse(magic.Parameters[2]));
                        break;
                    case "RegisterPlaneAirConditioner":
                        vroom.ValidateParametersCount(magic, 4);
                        RegisterPlaneAirConditioner(
                            magic.Parameters[0],
                            magic.Parameters[1],
                            int.Parse(magic.Parameters[2]),
                            int.Parse(magic.Parameters[3]));
                        break;
                    case "TestAirConditioner":
                        vroom.ValidateParametersCount(magic, 2);
                        TestAirConditioner(
                            magic.Parameters[0],
                            magic.Parameters[1]);
                        break;
                    case "FindAirConditioner":
                        vroom.ValidateParametersCount(magic, 2);
                        FindAirConditioner(
                            magic.Parameters[1],
                            magic.Parameters[0]);
                        break;
                    case "FindReport":
                        vroom.ValidateParametersCount(magic, 2);
                        FindReport(
                            magic.Parameters[0],
                            magic.Parameters[1]);
                        break;
                    case "Status":
                        vroom.ValidateParametersCount(magic, 0);
                        vroom.Status();
                        break;
                    default:
                        throw new IndexOutOfRangeException(OutputMessages.INVALIDCOMMAND);
                }
            }
            catch (FormatException ex)
            {
                throw new InvalidOperationException(OutputMessages.INVALIDCOMMAND, ex.InnerException);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new InvalidOperationException(OutputMessages.INVALIDCOMMAND, ex.InnerException);
            }
        }

        public string RegisterStationaryAirConditioner(string manufacturer, string model, int powerUsage, string energyEfficiencyRating)
        {
            StationaryAirConditioner airConditioner = new StationaryAirConditioner(manufacturer, model, powerUsage, energyEfficiencyRating);
            MyStuff.AirConditioners.Add(airConditioner);
            throw new InvalidOperationException(string.Format(OutputMessages.REGISTER, airConditioner.Model, airConditioner.Manufacturer));
        }

        public string RegisterCarAirConditioner(string model, string manufacturer, int volumeCoverage)
        {
            CarAirConditioner airConditioner = new CarAirConditioner(manufacturer, model, volumeCoverage);
            MyStuff.AirConditioners.Add(airConditioner);
            throw new InvalidOperationException(
                string.Format(OutputMessages.REGISTER, airConditioner.Model, airConditioner.Manufacturer));
        }

        public string RegisterPlaneAirConditioner(string manufacturer, string model, int volumeCoverage, int electricityUsed)
        {
            PlaneAirConditioner airConditioner = new PlaneAirConditioner(manufacturer, model, volumeCoverage, electricityUsed);
            MyStuff.AirConditioners.Add(airConditioner);
            throw new InvalidOperationException(
                string.Format(OutputMessages.TEST, airConditioner.Model, airConditioner.Manufacturer));
        }

        public string TestAirConditioner(string manufacturer, string model)
        {
            AirConditioner airConditioner = MyStuff.GetAirConditioner(manufacturer, model);
            var mark = airConditioner.Test();
            MyStuff.Reports.Add(new Report(airConditioner.Manufacturer, airConditioner.Model, mark));
            throw new InvalidOperationException(string.Format(OutputMessages.TEST, model, manufacturer));
        }

        public string FindAirConditioner(string manufacturer, string model)
        {
            AirConditioner airConditioner = MyStuff.GetAirConditioner(manufacturer, model);
            throw new InvalidOperationException(airConditioner.ToString());
        }

        public string FindReport(string manufacturer, string model)
        {
            Report report = MyStuff.GetReport(manufacturer, model);
            throw new InvalidOperationException(report.ToString());
        }

        public string FindAllReportsByManufacturer(string manufacturer)
        {
            List<Report> reports = MyStuff.GetReportsByManufacturer(manufacturer);
            if (reports.Count == 0)
            {
                return OutputMessages.NOREPORTS;
            }

            reports = reports.OrderBy(x => x.Mark).ToList();
            StringBuilder reportsPrint = new StringBuilder();
            reportsPrint.AppendLine(string.Format("Reports from {0}:", manufacturer));
            reportsPrint.Append(string.Join(Environment.NewLine, reports));
            return reportsPrint.ToString();
        }
    }
}
