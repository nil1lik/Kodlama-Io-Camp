using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

public class CourseProgrammeManager : ICourseProgrammeService
{
    ICourseProgrammeDal _courseProgrammeDal;
    public CourseProgrammeManager(ICourseProgrammeDal courseProgrammeDal)
    {
        _courseProgrammeDal = courseProgrammeDal;
    }

    public void Add(CourseProgramme courseProgramme)
    {
        _courseProgrammeDal.Add(courseProgramme);
    }

    public void Delete(CourseProgramme courseProgramme)
    {
        _courseProgrammeDal.Delete(courseProgramme);
    }

    public CourseProgramme Get(int id)
    {
        return _courseProgrammeDal.Get(x => x.Id == id);
    }

    public List<CourseProgramme> GetAll()
    {
        return _courseProgrammeDal.GetList().ToList();
    }

    public void Update(CourseProgramme courseProgramme)
    {
        _courseProgrammeDal.Update(courseProgramme);
    }
}