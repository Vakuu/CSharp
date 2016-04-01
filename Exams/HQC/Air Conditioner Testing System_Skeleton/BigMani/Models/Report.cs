namespace BigMani.Models
{
    using Core.Interfaces;

    public class Report : AirConditioner, IReport
    {
        private bool mark = false;

        public Report(string manufacturer, string model, bool mark)
            : base(manufacturer, model)
        {
            this.Mark = mark;
        }

        public bool Mark { get; set; }

        public override string ToString()
        {
            string isPassed = this.Mark ? "Passed" : "Failed";

            string result = "Report" + "\r\n" + "====================" + "\r\n" + "Manufacturer: " + Manufacturer + "\r\n" +
                      "Model: " + Model + "\r\n" + "Mark: " + isPassed + "\r\n" + "====================";

            return result;
        }
    }
}
