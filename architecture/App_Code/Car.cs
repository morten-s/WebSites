using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Car
{
    private string modelName;
    public string ModelName { get { return modelName; } }

    private string regNumber;
    public string RegNumber { get { return regNumber; } }

    private int prodYear;
    public int ProdYear { get { return prodYear; } }

    public Car(string modelName, int prodYear, string regNumber)
    {
        this.modelName = modelName;
        this.regNumber = regNumber;
        this.prodYear = prodYear;

    }

    public override string ToString()
    {
        return (modelName + " " + Convert.ToString(prodYear) + " " + regNumber);
    }

    public int age()
    {
        DateTime dt = DateTime.Now; //static method
        return (dt.Year - prodYear);
    }

    public int age(int year)
    {
        return (year - prodYear);
    }

}
