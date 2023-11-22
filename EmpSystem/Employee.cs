using EmpLib;
using System.Reflection.Emit;

public class Employee : Person, EmployeeContract
{


    public  event EventHandler Join;
    public event EventHandler Resign;



    



    private bool _contractSigned = false;
    private bool _hasReadContract = false;
    //type ctor for constructor
    public Employee() :base()//base means it will call base class constructor
    {
        this.ViewContract();
        this.Sign();
        this.EmpId= new Random(1000).Next();
        EmpUtils.EmpCount++;
    }

    public void TriggerJoinEvent()
    {
        this.Join.Invoke(this,null);
    }
    public void TriggerResignEvent()
    {
        this.Resign.Invoke(this, null);
    }

    public Employee(String pAadhar) :this() //this means it calls current class constructor
    {
        this.Aadhar = pAadhar;

    }
    public Employee(string pAadhar ,string pMobile): base(pAadhar,pMobile)
    {
        this.ViewContract();
        this.Sign();
        this.EmpId = new Random(1000).Next();
        EmpUtils.EmpCount++;
    }
    public void Sign()
    {
        _contractSigned = true;
    }
    public void ViewContract()
    {
        _hasReadContract = true;
    }
    private int _empId;//temporary variable
    public int EmpId { get { return _empId; } private set { _empId = value; } }
    public string Designation { get; set; }
    public double Salary { get; set; }
    public DateTime DOJ { get; set; }
    public bool IsActive { get; set; }

    public string empname { get; set; }
    public string AttendTraining(string pTraining)
    {
        return $"{this.Name} attended a training {pTraining}";
    }
    public void FillTimesheet(List<string> pTasks)
    {
        var csvTasks = "";
        foreach (var task in pTasks)
        {
            csvTasks = $"{csvTasks},{task} on {DateTime.Now.ToShortDateString()}";
        }

    }
    public override string Work()
    {
        return $"{this.Name} with {this.EmpId} works for 8hrs a day at kpmg";

    }
    public string Work(string task)
    {
        return $"{this.Name} with {this.EmpId} has {task} assigned on {DateTime.Today}";


    }
    public void setTaxInfo(string pTaxInfo)
    {
        this.TaxDetails = pTaxInfo;

    }
    public string GetTaxInfo()
    {
        return $"{this.Name} : Your Tax details are :{this.TaxDetails}";
    }

   

   

}

