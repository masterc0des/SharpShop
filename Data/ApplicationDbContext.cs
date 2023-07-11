using Microsoft.EntityFrameworkCore;
using SharpShop.Models;

namespace SharpShop.Data
{
    /* ApplicationDbContext links the database server to the data model classes in the asp.net application.
     * It is used for CRUD operations.
     * 
     * DbContext is the primary class that is responsible for interacting with the database. It is responsible for the following activities:
     * 
     * Querying: Converts LINQ-to-Entities queries to SQL query and sends them to the database.
     * 
     * Change Tracking: Keeps track of changes that occurred on the entities after querying from the database.
     * 
     * Persisting Data: Performs the Insert, Update and Delete operations to the database, based on entity states.
     * 
     * Caching: Provides first level caching by default. It stores the entities which have been retrieved during 
     * the life time of a context class.
     * 
     * Manage Relationship: Manages relationships using CSDL, MSL and SSDL in Db-First or Model-First approach, 
     * and using fluent API configurations in Code-First approach.
     * 
     * Object Materialization: Converts raw data from the database into entity objects.
     */

#pragma warning disable CS8618

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
