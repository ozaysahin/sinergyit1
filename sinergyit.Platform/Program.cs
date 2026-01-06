using sinergyit.Context;

static void Main(string[] args)
{
    var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=SinergyDb;Trusted_Connection=True;")
        .Options;

    var context = new AppDbContext(options);

}
