using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CourseCatalogContext(
                   serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null Context ");
            }

            if (context.Course.Any())
            {
                return; //leave script 
            }
            context.Course.AddRange(
                new Course()
                {
                    Id = 234,
                    CourseName = "Intro to Science",
                    CourseDescription = "Science for Begginers",
                    RoomNumber = 205,
                    StartTime = new TimeOnly(),
                    EndTIme = new TimeOnly()
                    
                   
                },
                new Course()
                {
                    Id = 235,
                    CourseName = "Intro to Math",
                    CourseDescription = "Math for Begginers",
                    RoomNumber = 209,
                    StartTime = new TimeOnly(),
                    EndTIme = new TimeOnly()
                    
                }
            );
            context.SaveChanges();
            // one more thing
        }
        
    }
}