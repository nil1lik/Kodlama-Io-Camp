﻿using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }

    public Instructor Get(int id)
    {
        return _instructorDal.Get(x => x.Id == id);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetList().ToList();
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}