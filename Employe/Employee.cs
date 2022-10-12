﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employe
{
    public class Employee
    {
         
        protected int id;
        protected string name;
        protected double basicsalary, hra, da, pf, netpaid;
        private static int count;
        public Employee(string name,double basicsalary) 
        {
            count++;
            this.id=count;
            this.name=name;
            this.basicsalary=basicsalary;
        }
        public virtual void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid=(hra + da + basicsalary) - pf;

        }
        public static string TotalCount()
        {
            return $"Total count is {count}";
        }
        public override string ToString()
        {
            return $"Employee details-->Id:{id}:Name:{name}Salary:{netpaid}";
        }
    }
    public class Manager : Employee
    {
        private double ta;
        public Manager(string name, double bs, double ta) : base(name, bs)
        {
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta) - pf;

        }

        public override string ToString()
        {
            return $"Manager details-->Id:{id}:Name:{name}Salary:{netpaid}";
        }
    }

    public class President : Employee
    {
        private double ma;
        public President(string name, double bs, double ma) : base(name, bs)
        {
            this.ma = ma;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ma) - pf;

        }

        public override string ToString()
        {
            return $"President details-->Id:{id}:Name:{name}Salary:{netpaid}";
        }
    }

    public class SalesManager : Employee
    {
        private double extraprofit;
        public SalesManager(string name, double bs, double extraprofit) : base(name, bs)
        {
            this.extraprofit = extraprofit;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + extraprofit) - pf;

        }

        public override string ToString()
        {
            return $"SalesManager details-->Id:{id}:Name:{name}Salary:{netpaid}";
        }

    }

}

