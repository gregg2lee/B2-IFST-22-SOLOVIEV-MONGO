using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UniversityManagement
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Code { get; set; }
        public int CreditHours { get; set; }
        public string Title { get; set; }
        public string[] Students { get; set; }
        public string ProfessorId { get; set; } 
    }
}
