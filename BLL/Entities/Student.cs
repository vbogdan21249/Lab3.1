using BLL.Interfaces;

namespace BLL.Entities;

public class Student : Person, IStudyBehaviour
{
    private IStudyBehaviour _studyBehaviour;
    public int Course { get; set; }
    public string StudnetCard { get; set; }
    public bool IsResident { get; set; }
    public PlaceOfResidance? Residance { get; set; }

    public class PlaceOfResidance
    {
        public PlaceOfResidance(int? dormitoryNumber, int? apartmentNumber)
        {
            DormitoryNumber = dormitoryNumber;
            ApartmentNumber = apartmentNumber;
        }

        public int? DormitoryNumber { get; set; }
        public int? ApartmentNumber { get; set; }

        public override string ToString()
        {
            return $"{DormitoryNumber}.{ApartmentNumber}";
        }
    }

    public Student(string name, int course, string studnetCard, string gender, bool isResident, int? dorm, int? room) :
        base(name, gender)
    {
        Course = course;
        StudnetCard = studnetCard;
        IsResident = isResident;

        if (isResident)
            Residance = new PlaceOfResidance(dorm, room);
        else
            Residance = null;

        _studyBehaviour = new StudyAtUniversity();
    }


    public string Study()
    {
        return _studyBehaviour.Study();
    }

    public void SetStudyBehaviour(IStudyBehaviour studyBehaviour)
    {
        _studyBehaviour = studyBehaviour;
    }
    
    public override string ToString()
    {
        string residencyInfo = IsResident ? $"Resides in {Residance}" : "Doesn't reside";
        return $"{base.ToString()}, Course: {Course}, Student Card: {StudnetCard}, {residencyInfo}, {Study()}";
    }
}