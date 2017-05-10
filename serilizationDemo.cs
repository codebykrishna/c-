using System;
using  System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
namespace  serilizationDemo
{
class program
{
static void Main(string[] args)
{
XmlSerializer s=new XmlSerializer(typeof(Configuration));
TextWriter save=new StreamWriter(@"save.xml");
Configuration c=new Configuration();
c.Pname="sony earphone";
c.Ptype="mobile earplug";
c.quantitiy=10;
c.price=1399.00f;
c.p_details=new ProductDetails("sony earphone","12345","01-02-2016","20-12-2050");
try
{
c.list.Add((A)(new A()));
A a=new B();
Console.WriteLine(a.pname);
c.list.Add((new C()) as A);
//c.list.Add(new D());
s.Serialize(save,c);
}catch(Exception ex)
{

    Console.WriteLine(ex);
}
save.Close();
}

}

public class Configuration
{
public string Pname {get;set;}
public string Ptype {get;set;}
public int quantitiy {get;set;}
public float price {get;set;}
public ProductDetails p_details;
public List<A> list {get;set;}
public Configuration()
{
list=new List<A>();
Pname=null;
Ptype=null;
quantitiy=0;
price=0.0f;
p_details=null;
}
}

public class ProductDetails
{
public string name {get;set;}
public string batch_no {get;set;}
public string mfg_date {get;set;}
public string exp_date {get;set;}

public ProductDetails()
{
name=null;
batch_no=null;
mfg_date=null;
exp_date=null;
}
public ProductDetails(string n,string b=null,string m=null,string e=null)
{

name=n;
batch_no=b;
mfg_date=m;
exp_date=e;

}

}

public class A 
{
public string pname;
public A()
{
pname="A";

}

public A(string a)
{
pname=a;
}

/*public void v()
{
    Console.WriteLine("hi i am parent ");
}
*/
}

public class B : A 
{
    public string cname;
    public B():base("parent of B")
    {
        cname="child B";
    }

    /*public void v()
    {
        Console.WriteLine("hi i am child B");
    }
    public void cfunc()
    {
        Console.WriteLine("child B function");
    }
    */
}

public class C : A 
{
    public string cname;
    public C():base("parent of C")
    {
        cname="child c";
    }
/* 
    public void v()
    {
        Console.WriteLine("hi i am child C");
    }
    public void cfunc()
    {
        Console.WriteLine("child C function");
    }
    */
}

public class D : A 
{
    public string cname;
    public D():base("parent of D")
    {
        cname="child D";
    }

 /*   public void v()
    {
        Console.WriteLine("hi i am child D");
    }
    public void cfunc()
    {
        Console.WriteLine("child D function");
    }
    */
}


}