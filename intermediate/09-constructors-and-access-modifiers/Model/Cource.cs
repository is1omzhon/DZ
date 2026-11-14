namespace Models.Course;

public class Course
{
    public string Title  {get;} 
    public int LessonCount {get;}


    public Course() : this("C# asoslari") {}

     public Course(string title) : this(title, 12) {}

    public Course(string title, int lessonCount)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(nameof(title), "Ism bo'sh bulmasligi kerak");
        }

        if(lessonCount <=0)
        {
            throw new ArgumentOutOfRangeException(nameof(lessonCount), "Darslar soni manfiy bula olmaydi!");
        }

        Title = title;
        LessonCount = lessonCount;
    }

    public string GetInfo()
    {
        return $"{Title} — {LessonCount} ta dars bor";
    }
    
}