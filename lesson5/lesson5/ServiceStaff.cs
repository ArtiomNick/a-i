namespace lesson5
{
    partial class Program
    {
        public abstract class ServiceStaff : Employee
        {
            public string Department { set; get; }

            public abstract void StuffPreparations();
        }
    }
}
