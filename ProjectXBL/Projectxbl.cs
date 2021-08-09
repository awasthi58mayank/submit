using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectXDAL;
using ProjectXDTO;

namespace ProjectXBL
{
    public class Projectxbl
    {
        ProjectxDal obj;
        public Projectxbl()
        {
            obj = new ProjectxDal();

        }
        public List<FacultyDTO> GetFaculties()
        {
            var facList = obj.GetFaculties();
            return facList;
        }
        public List<CourseDTO> GetCourses()
        {
            var CourseList = obj.GetCourses();
            return CourseList;
        }
        public int AddNewFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.AddNewFaculty(newFacDetails);
            return returnvalue;
        }
        public int UpdateFaculty(FacultyDTO newFacDetails)
        {
            int returnvalue = obj.UpdateFaculty(newFacDetails);
            return returnvalue;
        }
        public int DeleteFaculty(FacultyDTO FacID)
        {
            int returnvalue = obj.DeleteFaculty(FacID);
            return returnvalue;
        }
    }
}

