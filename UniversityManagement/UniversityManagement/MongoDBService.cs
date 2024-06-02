using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using UniversityManagement;

public class MongoDBService
{
    private readonly IMongoDatabase _database;

    public MongoDBService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("University");
    }

    public IMongoCollection<Student> Students => _database.GetCollection<Student>("STUDENTS");
    public IMongoCollection<Professor> Professors => _database.GetCollection<Professor>("PROFESSORS");
    public IMongoCollection<Course> Courses => _database.GetCollection<Course>("COURSES");
}