using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectXDTO;

namespace ProjectXDAL
{
    public class ProjectxDal
    {
        public ProjectxDal()
        {
        }
        public List<FacultyDTO> GetFaculties()
        {
            try
            {
                List<FacultyDTO> lstFaculty = new List<FacultyDTO>();
                ProjectXEntities objContext = new ProjectXEntities();
                var facDALListObj = objContext.Faculties.ToList();
                foreach (var item in facDALListObj)
                {
                    lstFaculty.Add(
                        new FacultyDTO
                        {
                            FacultyName = item.FacultyName,
                            EmailID = item.EmailID,
                            PSNo = item.PSNo

                        });
                }
                return lstFaculty;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooops! Something went Wrong!");
                throw ex;
            }
        }
        public List<CourseDTO> GetCourses()
        {
            try
            {
                List<CourseDTO> lstCourse = new List<CourseDTO>();
                ProjectXEntities objContext = new ProjectXEntities();
                var CourseDALListObj = objContext.Courses.ToList();
                foreach (var item in CourseDALListObj)
                {
                    lstCourse.Add(
                        new CourseDTO
                        {
                            CourseID = item.CourseID,
                            CourseTitle = item.CourseTitle,
                            Duration = item.Duration,
                            Owner = item.Owner,
                            AssessmentMode = item.AssessmentMode

                        }) ;
                }
                return lstCourse;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopss! Something went Wrong!");
                throw ex;
            }
        }
        public int AddNewFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXEntities())
                {
                    Faculty facDALObj = new Faculty();
                    facDALObj.FacultyName = newFacObj.FacultyName;
                    facDALObj.EmailID = newFacObj.EmailID;
                    facDALObj.PSNo = newFacObj.PSNo;
                    objContext.Faculties.Add(facDALObj);
                    ret = objContext.SaveChanges();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooops! Something went Wrong!");
                throw ex;
            }
        }
        public int UpdateFaculty(FacultyDTO newFacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXEntities())
                {
                    Faculty facDALObj = objContext.Faculties.Find(newFacObj.PSNo);
                    if (facDALObj != null)
                    {
                        objContext.Faculties.Attach(facDALObj);
                        facDALObj.FacultyName = newFacObj.FacultyName;
                        ret = objContext.SaveChanges();
                        return ret;
                    }
                    else
                    {
                        Console.WriteLine("User does not exist!");
                        return 0;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooops! Something went Wrong!");
                return 0;
            }
        }
        public int DeleteFaculty(FacultyDTO FacObj)
        {
            int ret = 0;
            try
            {
                using (var objContext = new ProjectXEntities ())
                {
                    Faculty facDALObj = objContext.Faculties.Find(FacObj.PSNo);
                    if (facDALObj != null)
                    {
                        facDALObj.PSNo = FacObj.PSNo;
                        objContext.Faculties.Remove(facDALObj);
                        ret = objContext.SaveChanges();
                        return ret;
                    }
                    else
                    {
                        Console.WriteLine("User does not exist!");
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ooopss! Something went Wrong!");
                return 0;
            }
        }
    }
}
