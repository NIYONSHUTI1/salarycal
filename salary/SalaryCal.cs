namespace Salary
{
    public class Calculator
    {
        public int em_id;
        public string em_name;
        public string em_position;
        public string em_gendeer;

        public double MonthlySalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - (((grossSalary * 30) / 100) + ((grossSalary * 5) / 100) + ((grossSalary * 3) / 100));
            return salary;
        }

        public double HourlySalary(double rate, double hour)
        {
            double salary;
            salary=(rate*hour)-((((rate*hour)*5)/100)+(((rate*hour)*3)/100));
            return salary;
        }

        public double OneTimeSalary(double grossSalary)
        {
            double salary;
            salary = grossSalary - ((grossSalary * 30) / 100);
            return salary;
        }
    }
}