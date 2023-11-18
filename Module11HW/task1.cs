//using system;
//using system.collections.generic;
//using system.linq;

//public enum vacancy
//{
//    manager,
//    clerk,
//    engineer,
//    developer
//}

//public enum gender
//{
//    male,
//    female,
//    unspecified
//}

//public interface iemployee
//{
//    string tostring();
//}

//public struct employee : iemployee
//{
//    public string name;
//    public vacancy vacancy;
//    public datetime hiringdate;
//    public int salary;
//    public gender gender;

//    public employee(string name, vacancy vacancy, datetime hiringdate, int salary, gender gender)
//    {
//        name = name;
//        vacancy = vacancy;
//        hiringdate = hiringdate;
//        salary = salary;
//        gender = gender;
//    }

//    public override string tostring()
//    {
//        return $"name: {name}, position: {vacancy}, hiring date: {hiringdate.toshortdatestring()}, salary: {salary}, gender: {gender}";
//    }
//}

//public class employeemanager
//{
//    private list<employee> employees;

//    public employeemanager()
//    {
//        employees = new list<employee>();
//    }

//    public void addemployee(employee employee)
//    {
//        employees.add(employee);
//    }

//    public void printallemployees()
//    {
//        foreach (var employee in employees)
//        {
//            console.writeline(employee.tostring());
//        }
//    }

//    public void printemployeesbyposition(vacancy vacancy)
//    {
//        foreach (var employee in employees.where(e => e.vacancy == vacancy))
//        {
//            console.writeline(employee.tostring());
//        }
//    }

//    public void printmanagerswithhighersalarythanaverageclerks()
//    {
//        var averageclerksalary = employees.where(e => e.vacancy == vacancy.clerk).average(e => e.salary);
//        var filteredmanagers = employees.where(e => e.vacancy == vacancy.manager && e.salary > averageclerksalary)
//                                        .orderby(e => e.name);

//        foreach (var manager in filteredmanagers)
//        {
//            console.writeline(manager.tostring());
//        }
//    }

//    public void printemployeeshiredafterdate(datetime date)
//    {
//        var filteredemployees = employees.where(e => e.hiringdate > date).orderby(e => e.name);
//        foreach (var employee in filteredemployees)
//        {
//            console.writeline(employee.tostring());
//        }
//    }

//    public void printemployeesbygender(gender gender)
//    {
//        var filteredemployees = employees.where(e => e.gender == gender || gender == gender.unspecified);
//        foreach (var employee in filteredemployees)
//        {
//            console.writeline(employee.tostring());
//        }
//    }
//}
//class program
//{
//    static void main(string[] args)
//    {
//        var employeemanager = new employeemanager();


//        employeemanager.addemployee(new employee("john mactavish", vacancy.manager, new datetime(2020, 1, 1), 50000, gender.male));
//        employeemanager.addemployee(new employee("jane jackson", vacancy.clerk, new datetime(2019, 5, 10), 30000, gender.female));
//        employeemanager.addemployee(new employee("mike trump", vacancy.manager, new datetime(2020, 1, 1), 50000, gender.male));
//        employeemanager.addemployee(new employee("george smith", vacancy.clerk, new datetime(2019, 5, 10), 30000, gender.female));
//        employeemanager.addemployee(new employee("alex mason", vacancy.engineer, new datetime(2018, 3, 15), 70000, gender.female));
//        employeemanager.addemployee(new employee("carl brown", vacancy.developer, new datetime(2021, 6, 20), 80000, gender.male));
//        employeemanager.addemployee(new employee("chris green", vacancy.manager, new datetime(2017, 11, 5), 90000, gender.male));
//        employeemanager.addemployee(new employee("diana white", vacancy.clerk, new datetime(2019, 2, 28), 45000, gender.female));
//        employeemanager.addemployee(new employee("ethan black", vacancy.engineer, new datetime(2020, 7, 10), 75000, gender.male));
//        employeemanager.addemployee(new employee("fiona grey", vacancy.developer, new datetime(2021, 1, 22), 85000, gender.female));
//        employeemanager.addemployee(new employee("george yellow", vacancy.manager, new datetime(2018, 8, 14), 65000, gender.male));
//        employeemanager.addemployee(new employee("hannah parker", vacancy.clerk, new datetime(2020, 12, 1), 40000, gender.female));

//        // displaying all employees
//        console.writeline("all employees:");
//        employeemanager.printallemployees();

//        // displaying employees by a specific position
//        console.writeline("\nmanagers:");
//        employeemanager.printemployeesbyposition(vacancy.manager);

//        // displaying managers with higher salary than average clerks
//        console.writeline("\nmanagers with higher salary than average clerks:");
//        employeemanager.printmanagerswithhighersalarythanaverageclerks();

//        // displaying employees hired after a specific date
//        console.writeline("\nemployees hired after 01/01/2020:");
//        employeemanager.printemployeeshiredafterdate(new datetime(2020, 1, 1));

//        // displaying employees by gender
//        console.writeline("\nmale employees:");
//        employeemanager.printemployeesbygender(gender.male);

//        // wait for a key press before closing the console window
//        console.readkey();
//    }
//}
