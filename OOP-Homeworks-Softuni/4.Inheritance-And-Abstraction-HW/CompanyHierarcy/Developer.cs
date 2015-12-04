using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarcy
{
    class Developer : Employee
    {
        public Developer(string id, string firstName, string lastName, int salary, DepartmentType department)
            : base(id, firstName, lastName, salary, department)
        {
        }
    }

    class Project
    {
        protected string projectName;
        protected string state;
        protected DateTime dt;
        public Project(string projectName, DateTime projectStartDate, string state)
        {
            this.Projectname = projectName;
            this.ProjectStartDate = projectStartDate;
            this.IsClosed = state;

        }

        public string Projectname
        {
            get { return this.projectName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project name cannot be null");
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.dt; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project start date name cannot be null");
                }
                this.dt = value;
            }
        }

        public string Details { get; set; }

        public string State
        {
            get { return this.state; }
            set
            {
                if (value == null)
                {
                   throw new ArgumentNullException("State cannot be null."); 
                }
                this.state = value;

            }
        }



        public string IsClosed
        {
            get { return this.state; }
            set
            {
                CloseProject();
                
            }
        }

        public string CloseProject()
        {
            if (this.IsClosed.Equals("open"))
            {
                return IsClosed = "closed";
            }
            return "closed";
        }

        public override string ToString()
        { 
            return string.Format("{0}, Project name - {1}, Project start date: {2}, Details {3}, State {4}",base.ToString(),
                this.Projectname, this.ProjectStartDate, this.Details, this.IsClosed);
        }
    }
}
